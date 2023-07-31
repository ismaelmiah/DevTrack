# DevTrack (DevSkill Training Team Project)

# Team Members
![Screenshot 2023-07-31 223815](https://github.com/prose/prose/assets/29182508/cd2c6b47-2a71-4d96-b9b7-52d0cbc4b484)

### It's a tracking tool that will track user activity like keypress, and mouse movement, and take a screenshot from the client system in an arbitrary way of times. It will be used as a Windows service and to use it 100% there will be a Desktop UI application from where a user will interact with this app.

## SQLite Update Database Command
- `dotnet ef database update --project DevTrack.TrackerWorkerService --context DevTrackContext`

## SqlServer Update Database Command
- `dotnet ef database update --project DevTrack.Web --context ApplicationDbContext`
- `dotnet ef database update --project DevTrack.Web --context DevTrackWebContext`




### Before Run Project, Make sure
- Set Startup Project
- Change connection string followed by your machine in `appsettings.json`
