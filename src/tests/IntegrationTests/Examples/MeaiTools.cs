/*
order: 20
title: MEAI Tools
slug: meai-tools

Shows how to use Label Studio operations as AIFunction tools with any IChatClient.
*/

using Microsoft.Extensions.AI;

namespace LabelStudio.IntegrationTests;

public partial class Tests
{
    [TestMethod]
    public void Example_CreateMeaiTools()
    {
        //// Create an authenticated Label Studio client.
        using var client = GetAuthenticatedClient();

        //// Create AIFunction tools for use with any IChatClient.
        var listProjectsTool = client.AsListProjectsTool();
        var getProjectTool = client.AsGetProjectTool();
        var listTasksTool = client.AsListTasksTool();
        var createAnnotationTool = client.AsCreateAnnotationTool();

        //// All tools should be valid AIFunction instances.
        listProjectsTool.Should().NotBeNull();
        listProjectsTool.Name.Should().Be("ListLabelingProjects");

        getProjectTool.Should().NotBeNull();
        getProjectTool.Name.Should().Be("GetLabelingProject");

        listTasksTool.Should().NotBeNull();
        listTasksTool.Name.Should().Be("ListLabelingTasks");

        createAnnotationTool.Should().NotBeNull();
        createAnnotationTool.Name.Should().Be("CreateAnnotation");

        //// Tools can be added to ChatOptions for use with any IChatClient.
        var options = new ChatOptions
        {
            Tools =
            [
                listProjectsTool,
                getProjectTool,
                listTasksTool,
                createAnnotationTool,
            ],
        };

        options.Tools.Should().HaveCount(4);
    }
}
