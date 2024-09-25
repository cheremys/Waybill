var builder = DistributedApplication.CreateBuilder(args);
var apiService = builder.AddProject<Projects.Waybill_Api>("apiservice");

builder.AddProject<Projects.Waybill_Web>("webfrontend")
    .WithExternalHttpEndpoints()
    .WithReference(apiService);
builder.Build().Run();