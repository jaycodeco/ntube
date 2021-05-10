import argparse
from googleapiclient.discovery import build
from googleapiclient.errors import HttpError


DEVELOPER_KEY = 'AIzaSyD6FMCZQyNq0qmnVW_CofjVe-uf3P7DIB0'
YOUTUBE_API_SERVICE_NAME = 'youtube'
YOUTUBE_API_VERSION = 'v3'



videos = []


def youtube_search(options):
    youtube = build(YOUTUBE_API_SERVICE_NAME, YOUTUBE_API_VERSION,
    developerKey=DEVELOPER_KEY)

    search_response = youtube.search().list(
    q=options,
    part='id,snippet',
    maxResults=20
    ).execute()


    for search_result in search_response.get('items', []):

        if search_result['id']['kind'] == 'youtube#video':
            videos.append(f"{(search_result['id']['videoId'])} ^ {(search_result['snippet']['title'])} ^ {(search_result['snippet']['thumbnails']['medium']['url'])}")
    
    
def register_search():

    file = open("./nBack/search_results.txt", "w")

    end_vid = ""

    for  video in videos:
        try:
            file.write(video.replace('\U0001f525', '').replace('\U0001f34b',''))
            file.write(" =")
            end_vid = video
        except Exception as e:
            pass
            
    file.write(end_vid.replace('\U0001f525', '').replace('\U0001f34b',''))
    file.close()


def search_vids(search_term):
    
    try:
        youtube_search(search_term)   
        register_search()
        print("yo")
    except HttpError:
        print ('An HTTP error occurred')
        