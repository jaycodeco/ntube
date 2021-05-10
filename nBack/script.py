import sys
import time
from download import *
from search import search_vids


def downloading(flag):
    if flag == '--file' :
        download_in_file(sys.argv[3], sys.argv[4])

    if flag == '--url' :
        download_single(sys.argv[3], sys.argv[4])

    if flag == '--list' :
        download_playList(sys.argv[3], sys.argv[4])

    if flag == '--chc' :
        download_id(sys.argv[3], sys.argv[4])





if __name__ == '__main__':
    if sys.argv[1] == '-s' :
        search_vids(sys.argv[2])

    if sys.argv[1] == '-d' :
        downloading(sys.argv[2])