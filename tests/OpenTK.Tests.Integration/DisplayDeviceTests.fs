namespace OpenTK.Tests.Integration

open Xunit
open FsCheck
open FsCheck.Xunit
open System
open System.Runtime.InteropServices
open OpenTK

module DisplayDevice =
    let AllIndices = [
        OpenTK.DisplayIndex.Primary;
        OpenTK.DisplayIndex.First;
        OpenTK.DisplayIndex.Second;
        OpenTK.DisplayIndex.Third;
        OpenTK.DisplayIndex.Fourth;
        OpenTK.DisplayIndex.Fifth;
        OpenTK.DisplayIndex.Sixth;]

    module General =
        [<Fact>]
        let ``Default DisplayDevice is not null`` () =
            let device = OpenTK.DisplayDevice.Default
            Assert.NotNull(device)

        [<Fact>]
        let ``DisplayDevice.Default == DisplayDevice.GetDisplay(Default)`` () =
            Assert.Equal(
                OpenTK.DisplayDevice.Default,
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Default))

        [<Fact>]
        let ``DisplayDevice.GetDisplay(Default) == DisplayDevice.GetDisplay(Primary)`` () =
            Assert.Equal(
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Default),
                OpenTK.DisplayDevice.GetDisplay(OpenTK.DisplayIndex.Primary))
                
        [<Fact>]
        let ``DisplayDevice.GetDisplay(i) doesn't throw`` () =

            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                ignore device

        [<Fact>]
        let ``DisplayDevice.Default.IsPrimary == true`` () =
            Assert.True(DisplayDevice.Default.IsPrimary)
                                
        [<Fact>]
        let ``Only the primary DisplayDevice has IsPrimary == true`` () =
            let primaryDevice = OpenTK.DisplayDevice.Default

            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) && not(device.Equals(primaryDevice)) then
                    Assert.False(device.IsPrimary)
          
        [<Fact>]
        let ``CurrentResolution is not zero`` () =
            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    let resoulution = device.CurrentResolution;
                    Assert.NotEqual(0, resoulution.Width)
                    Assert.NotEqual(0, resoulution.Height)
                    Assert.NotEqual(0, resoulution.BitsPerPixel)
                    Assert.NotEqual(0.0f, resoulution.RefreshRate)

        [<Fact>]
        let ``Can change to every available resolution`` () =
            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    for resolution in device.AvailableResolutions do
                        device.ChangeResolution(resolution)
                              
        [<Fact>]
        let ``ChangeResoultion updates CurrentResolution`` () =
            for index in AllIndices do
                let device = OpenTK.DisplayDevice.GetDisplay(index)
                if not(Object.ReferenceEquals(device, null)) then
                    for resolution in device.AvailableResolutions do
                        device.ChangeResolution(resolution)
                        Assert.Equal(resolution, device.CurrentResolution)
                    