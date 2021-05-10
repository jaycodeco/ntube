try:
    from pytube import YouTube
    import os
    from pytube.cli import on_progress
except Exception as e:
    print(e," not found")

global file_size
file_size = 0


def update_progress(streams, chunk = bytes, remaining = int):
    percent = str((100*(file_size-remaining))/file_size)
    file = open("./nBack/progress.txt", "w")
    file.write(percent)
    file.close()


def download_single(choice,url):

    global file_size
    path_file = open("./nBack/path.txt", "r")
    save_path = path_file.readlines()[0]
    path_file.close()
    
    try:
        data = YouTube(url, on_progress_callback=update_progress)
        
        if(choice == "m4h"):
            down_file = data.streams.filter(progressive=True).order_by('resolution').desc().first()
        elif(choice == "m4l"):
            down_file = data.streams.filter(progressive=True).order_by('resolution').desc().last()
        elif(choice == "m3"):
            down_file = data.streams.filter(only_audio=True).first()
           
        
        file_size = down_file.filesize
        
        out_file = down_file.download(output_path=save_path)
        
        if(choice == "m3"):
            # save the file 
            base, ext = os.path.splitext(out_file)
            new_file = base + '.mp3'
            os.rename(out_file, new_file) 
        
        print('sucess')
            
    except Exception as e:
        print("error: ", e)
        
        
        
def download_in_file(choice, file_path):
    
    file = open(file_path, "r")
    urls = file.readlines()
    file.close()
    
    for url in urls:
        download_single(choice, url.replace('\n',''))
        
        
    
def download_playList(choice,ids):
    
    urls = ids.split(',')
    
    for url in urls:
        download_single(choice, url.replace('\n',''))
        


def download_id(choice,id):
       
    idf = id.replace('\n','').replace('\n','').replace('\n','').replace('\n','')
    url = f"https://www.youtube.com/watch?v={idf}"

    #file = open("./nBack/progress.txt", "w")
    #file.write(idf)
    #file.close()
    download_single(choice, url)