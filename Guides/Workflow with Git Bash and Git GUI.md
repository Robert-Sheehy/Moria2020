## Normal session expected workflow steps.

* It is expected that you already have forked and contributed to the projects at this stage *

1.  Clone your project from your local repository, as before
2.  Typically, we can expect that there have been other updates to the Group Repository which are not in your local version.
3.  We need to get (fetch) these from the Group Repo.
4.  Use Windows Explorer to navigate to your local repository, right click and select Git Bash
5.  This opens a console window.
6.  We need to link the Group Repository to this local repository, first we check the current remotes attached by typing
    
    $ git remote -v
    
7.  This should list all remotes, typically the only one will be your personal one (listed twice for push and fetch)
8.  If the Group repository is not listed, then we add this as a remote using

    $ git remote add GroupRepo ( URL of Group repo here )
    
    Note:   GroupRepo is just a name that we assign to it, it can be anything, it is usually referred to as the upstream
9.  Repeat step 6 and we should now see the Group Repository also listed.
10. To "fetch" the changes made to the Group repo we..
    
    $ git fetch GroupRepo
    
    If there are changes, a summary of the changes will be listed
11. The changes have now been fetched, but are not yet implemented. (There may be conflicts etc...). We merge with the local

    $ git merge GroupRepo/master
    
12. Hopefully, this will not have conflicts (later), and your local version is now up to date with both personal and group repositories
13. IMPORTANT:  We now need to update your personal repo, before we start to work, i.e. we push changes to personal repo
    Git GUI will not recognise these changes when we RESCAN, so we select the Commit pull-down menu and select Stage To Commit
    We can then Push the changes to update our personal repo.
14. We can now work away on the local copy of the project.
15. When we are finished, all changes need to be staged, committed, pushed and then a Pull Request made as before.
