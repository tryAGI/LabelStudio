/*
order: 10
title: Projects
slug: projects

Shows how to create a Label Studio client and list labeling projects.
*/

namespace LabelStudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public async Task Example_ListProjects()
    {
        //// Create an authenticated Label Studio client.
        using var client = GetAuthenticatedClient();

        //// List all labeling projects.
        var projects = await client.Projects2.ListAsync(
            page: 1,
            pageSize: 10);

        projects.Should().NotBeNull();
        projects.Count.Should().BeGreaterThanOrEqualTo(0);
    }

    [TestMethod]
    public async Task Example_GetProject()
    {
        //// Create an authenticated Label Studio client.
        using var client = GetAuthenticatedClient();

        //// First list projects to get a valid ID.
        var projects = await client.Projects2.ListAsync(
            page: 1,
            pageSize: 1);

        if (projects.Results.Count == 0)
        {
            Assert.Inconclusive("No projects found to test with.");
            return;
        }

        var projectId = projects.Results[0].Id;

        //// Get detailed information about a specific project.
        var project = await client.Projects2.GetAsync(id: projectId);

        project.Should().NotBeNull();
        project.Id.Should().Be(projectId);
        project.Title.Should().NotBeNullOrEmpty();
    }
}
