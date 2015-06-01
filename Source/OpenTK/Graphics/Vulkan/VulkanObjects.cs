
#region License
//
// The Open Toolkit Library License
//
// Copyright (c) 2015 the Open Toolkit library.
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights to 
// use, copy, modify, merge, publish, distribute, sublicense, and/or sell copies of
// the Software, and to permit persons to whom the Software is furnished to do
// so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in all
// copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND,
// EXPRESS OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES
// OF MERCHANTABILITY, FITNESS FOR A PARTICULAR PURPOSE AND
// NONINFRINGEMENT. IN NO EVENT SHALL THE AUTHORS OR COPYRIGHT
// HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER LIABILITY,
// WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR
// OTHER DEALINGS IN THE SOFTWARE.
//
#endregion

using System;

namespace OpenTK.Graphics.Vulkan
{
	public struct Object
	{
		internal Int64 Handle;

		public Object(Int64 handle)
		{
			Handle = handle;
		}
	}
	public struct Instance
	{
		internal IntPtr Handle;

		public Instance(IntPtr handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(Instance stance)
		{
			return new Object(stance.Handle.ToInt64());
		}
		
		public static explicit operator Instance(Object ject)
		{
			return new Instance(new IntPtr(ject.Handle));
		}
	}
	public struct PhysicalDevice
	{
		internal IntPtr Handle;

		public PhysicalDevice(IntPtr handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(PhysicalDevice ysicaldevice)
		{
			return new Object(ysicaldevice.Handle.ToInt64());
		}
		
		public static explicit operator PhysicalDevice(Object ject)
		{
			return new PhysicalDevice(new IntPtr(ject.Handle));
		}
	}
	public struct Device
	{
		internal IntPtr Handle;

		public Device(IntPtr handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(Device vice)
		{
			return new Object(vice.Handle.ToInt64());
		}
		
		public static explicit operator Device(Object ject)
		{
			return new Device(new IntPtr(ject.Handle));
		}
	}
	public struct Queue
	{
		internal IntPtr Handle;

		public Queue(IntPtr handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(Queue eue)
		{
			return new Object(eue.Handle.ToInt64());
		}
		
		public static explicit operator Queue(Object ject)
		{
			return new Queue(new IntPtr(ject.Handle));
		}
	}
	public struct CmdBuffer
	{
		internal IntPtr Handle;

		public CmdBuffer(IntPtr handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(CmdBuffer dbuffer)
		{
			return new Object(dbuffer.Handle.ToInt64());
		}
		
		public static explicit operator CmdBuffer(Object ject)
		{
			return new CmdBuffer(new IntPtr(ject.Handle));
		}
	}
	public struct NonDispatchable
	{
		internal Int64 Handle;

		public NonDispatchable(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator Object(NonDispatchable ndispatchable)
		{
			return new Object(ndispatchable.Handle);
		}
		
		public static explicit operator NonDispatchable(Object ject)
		{
			return new NonDispatchable(ject.Handle);
		}
	
	}
	public struct DeviceMemory
	{
		internal Int64 Handle;

		public DeviceMemory(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DeviceMemory vicememory)
		{
			return new NonDispatchable(vicememory.Handle);
		}
		
		public static explicit operator DeviceMemory(NonDispatchable ndispatchable)
		{
			return new DeviceMemory(ndispatchable.Handle);
		}
		public static implicit operator Object(DeviceMemory vicememory)
		{
			return new Object(vicememory.Handle);
		}
		
		public static explicit operator DeviceMemory(Object ject)
		{
			return new DeviceMemory(ject.Handle);
		}
	
	}
	public struct Buffer
	{
		internal Int64 Handle;

		public Buffer(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Buffer ffer)
		{
			return new NonDispatchable(ffer.Handle);
		}
		
		public static explicit operator Buffer(NonDispatchable ndispatchable)
		{
			return new Buffer(ndispatchable.Handle);
		}
		public static implicit operator Object(Buffer ffer)
		{
			return new Object(ffer.Handle);
		}
		
		public static explicit operator Buffer(Object ject)
		{
			return new Buffer(ject.Handle);
		}
	
	}
	public struct BufferView
	{
		internal Int64 Handle;

		public BufferView(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(BufferView fferview)
		{
			return new NonDispatchable(fferview.Handle);
		}
		
		public static explicit operator BufferView(NonDispatchable ndispatchable)
		{
			return new BufferView(ndispatchable.Handle);
		}
		public static implicit operator Object(BufferView fferview)
		{
			return new Object(fferview.Handle);
		}
		
		public static explicit operator BufferView(Object ject)
		{
			return new BufferView(ject.Handle);
		}
	
	}
	public struct Image
	{
		internal Int64 Handle;

		public Image(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Image age)
		{
			return new NonDispatchable(age.Handle);
		}
		
		public static explicit operator Image(NonDispatchable ndispatchable)
		{
			return new Image(ndispatchable.Handle);
		}
		public static implicit operator Object(Image age)
		{
			return new Object(age.Handle);
		}
		
		public static explicit operator Image(Object ject)
		{
			return new Image(ject.Handle);
		}
	
	}
	public struct ImageView
	{
		internal Int64 Handle;

		public ImageView(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(ImageView ageview)
		{
			return new NonDispatchable(ageview.Handle);
		}
		
		public static explicit operator ImageView(NonDispatchable ndispatchable)
		{
			return new ImageView(ndispatchable.Handle);
		}
		public static implicit operator Object(ImageView ageview)
		{
			return new Object(ageview.Handle);
		}
		
		public static explicit operator ImageView(Object ject)
		{
			return new ImageView(ject.Handle);
		}
	
	}
	public struct ColorAttachmentView
	{
		internal Int64 Handle;

		public ColorAttachmentView(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(ColorAttachmentView lorattachmentview)
		{
			return new NonDispatchable(lorattachmentview.Handle);
		}
		
		public static explicit operator ColorAttachmentView(NonDispatchable ndispatchable)
		{
			return new ColorAttachmentView(ndispatchable.Handle);
		}
		public static implicit operator Object(ColorAttachmentView lorattachmentview)
		{
			return new Object(lorattachmentview.Handle);
		}
		
		public static explicit operator ColorAttachmentView(Object ject)
		{
			return new ColorAttachmentView(ject.Handle);
		}
	
	}
	public struct DepthStencilView
	{
		internal Int64 Handle;

		public DepthStencilView(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DepthStencilView pthstencilview)
		{
			return new NonDispatchable(pthstencilview.Handle);
		}
		
		public static explicit operator DepthStencilView(NonDispatchable ndispatchable)
		{
			return new DepthStencilView(ndispatchable.Handle);
		}
		public static implicit operator Object(DepthStencilView pthstencilview)
		{
			return new Object(pthstencilview.Handle);
		}
		
		public static explicit operator DepthStencilView(Object ject)
		{
			return new DepthStencilView(ject.Handle);
		}
	
	}
	public struct Shader
	{
		internal Int64 Handle;

		public Shader(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Shader ader)
		{
			return new NonDispatchable(ader.Handle);
		}
		
		public static explicit operator Shader(NonDispatchable ndispatchable)
		{
			return new Shader(ndispatchable.Handle);
		}
		public static implicit operator Object(Shader ader)
		{
			return new Object(ader.Handle);
		}
		
		public static explicit operator Shader(Object ject)
		{
			return new Shader(ject.Handle);
		}
	
	}
	public struct Pipeline
	{
		internal Int64 Handle;

		public Pipeline(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Pipeline peline)
		{
			return new NonDispatchable(peline.Handle);
		}
		
		public static explicit operator Pipeline(NonDispatchable ndispatchable)
		{
			return new Pipeline(ndispatchable.Handle);
		}
		public static implicit operator Object(Pipeline peline)
		{
			return new Object(peline.Handle);
		}
		
		public static explicit operator Pipeline(Object ject)
		{
			return new Pipeline(ject.Handle);
		}
	
	}
	public struct PipelineLayout
	{
		internal Int64 Handle;

		public PipelineLayout(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(PipelineLayout pelinelayout)
		{
			return new NonDispatchable(pelinelayout.Handle);
		}
		
		public static explicit operator PipelineLayout(NonDispatchable ndispatchable)
		{
			return new PipelineLayout(ndispatchable.Handle);
		}
		public static implicit operator Object(PipelineLayout pelinelayout)
		{
			return new Object(pelinelayout.Handle);
		}
		
		public static explicit operator PipelineLayout(Object ject)
		{
			return new PipelineLayout(ject.Handle);
		}
	
	}
	public struct Sampler
	{
		internal Int64 Handle;

		public Sampler(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Sampler mpler)
		{
			return new NonDispatchable(mpler.Handle);
		}
		
		public static explicit operator Sampler(NonDispatchable ndispatchable)
		{
			return new Sampler(ndispatchable.Handle);
		}
		public static implicit operator Object(Sampler mpler)
		{
			return new Object(mpler.Handle);
		}
		
		public static explicit operator Sampler(Object ject)
		{
			return new Sampler(ject.Handle);
		}
	
	}
	public struct DescriptorSet
	{
		internal Int64 Handle;

		public DescriptorSet(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DescriptorSet scriptorset)
		{
			return new NonDispatchable(scriptorset.Handle);
		}
		
		public static explicit operator DescriptorSet(NonDispatchable ndispatchable)
		{
			return new DescriptorSet(ndispatchable.Handle);
		}
		public static implicit operator Object(DescriptorSet scriptorset)
		{
			return new Object(scriptorset.Handle);
		}
		
		public static explicit operator DescriptorSet(Object ject)
		{
			return new DescriptorSet(ject.Handle);
		}
	
	}
	public struct DescriptorSetLayout
	{
		internal Int64 Handle;

		public DescriptorSetLayout(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DescriptorSetLayout scriptorsetlayout)
		{
			return new NonDispatchable(scriptorsetlayout.Handle);
		}
		
		public static explicit operator DescriptorSetLayout(NonDispatchable ndispatchable)
		{
			return new DescriptorSetLayout(ndispatchable.Handle);
		}
		public static implicit operator Object(DescriptorSetLayout scriptorsetlayout)
		{
			return new Object(scriptorsetlayout.Handle);
		}
		
		public static explicit operator DescriptorSetLayout(Object ject)
		{
			return new DescriptorSetLayout(ject.Handle);
		}
	
	}
	public struct DescriptorPool
	{
		internal Int64 Handle;

		public DescriptorPool(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DescriptorPool scriptorpool)
		{
			return new NonDispatchable(scriptorpool.Handle);
		}
		
		public static explicit operator DescriptorPool(NonDispatchable ndispatchable)
		{
			return new DescriptorPool(ndispatchable.Handle);
		}
		public static implicit operator Object(DescriptorPool scriptorpool)
		{
			return new Object(scriptorpool.Handle);
		}
		
		public static explicit operator DescriptorPool(Object ject)
		{
			return new DescriptorPool(ject.Handle);
		}
	
	}
	public struct DynamicStateObject
	{
		internal Int64 Handle;

		public DynamicStateObject(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(DynamicStateObject namicstateobject)
		{
			return new NonDispatchable(namicstateobject.Handle);
		}
		
		public static explicit operator DynamicStateObject(NonDispatchable ndispatchable)
		{
			return new DynamicStateObject(ndispatchable.Handle);
		}
		public static implicit operator Object(DynamicStateObject namicstateobject)
		{
			return new Object(namicstateobject.Handle);
		}
		
		public static explicit operator DynamicStateObject(Object ject)
		{
			return new DynamicStateObject(ject.Handle);
		}
	
	}
	public struct DynamicVpState
	{
		internal Int64 Handle;

		public DynamicVpState(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator DynamicStateObject(DynamicVpState namicvpstate)
		{
			return new DynamicStateObject(namicvpstate.Handle);
		}
		
		public static explicit operator DynamicVpState(DynamicStateObject namicstateobject)
		{
			return new DynamicVpState(namicstateobject.Handle);
		}
		public static implicit operator NonDispatchable(DynamicVpState namicvpstate)
		{
			return new NonDispatchable(namicvpstate.Handle);
		}
		
		public static explicit operator DynamicVpState(NonDispatchable ndispatchable)
		{
			return new DynamicVpState(ndispatchable.Handle);
		}
		public static implicit operator Object(DynamicVpState namicvpstate)
		{
			return new Object(namicvpstate.Handle);
		}
		
		public static explicit operator DynamicVpState(Object ject)
		{
			return new DynamicVpState(ject.Handle);
		}
	
	}
	public struct DynamicRsState
	{
		internal Int64 Handle;

		public DynamicRsState(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator DynamicStateObject(DynamicRsState namicrsstate)
		{
			return new DynamicStateObject(namicrsstate.Handle);
		}
		
		public static explicit operator DynamicRsState(DynamicStateObject namicstateobject)
		{
			return new DynamicRsState(namicstateobject.Handle);
		}
		public static implicit operator NonDispatchable(DynamicRsState namicrsstate)
		{
			return new NonDispatchable(namicrsstate.Handle);
		}
		
		public static explicit operator DynamicRsState(NonDispatchable ndispatchable)
		{
			return new DynamicRsState(ndispatchable.Handle);
		}
		public static implicit operator Object(DynamicRsState namicrsstate)
		{
			return new Object(namicrsstate.Handle);
		}
		
		public static explicit operator DynamicRsState(Object ject)
		{
			return new DynamicRsState(ject.Handle);
		}
	
	}
	public struct DynamicCbState
	{
		internal Int64 Handle;

		public DynamicCbState(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator DynamicStateObject(DynamicCbState namiccbstate)
		{
			return new DynamicStateObject(namiccbstate.Handle);
		}
		
		public static explicit operator DynamicCbState(DynamicStateObject namicstateobject)
		{
			return new DynamicCbState(namicstateobject.Handle);
		}
		public static implicit operator NonDispatchable(DynamicCbState namiccbstate)
		{
			return new NonDispatchable(namiccbstate.Handle);
		}
		
		public static explicit operator DynamicCbState(NonDispatchable ndispatchable)
		{
			return new DynamicCbState(ndispatchable.Handle);
		}
		public static implicit operator Object(DynamicCbState namiccbstate)
		{
			return new Object(namiccbstate.Handle);
		}
		
		public static explicit operator DynamicCbState(Object ject)
		{
			return new DynamicCbState(ject.Handle);
		}
	
	}
	public struct DynamicDsState
	{
		internal Int64 Handle;

		public DynamicDsState(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator DynamicStateObject(DynamicDsState namicdsstate)
		{
			return new DynamicStateObject(namicdsstate.Handle);
		}
		
		public static explicit operator DynamicDsState(DynamicStateObject namicstateobject)
		{
			return new DynamicDsState(namicstateobject.Handle);
		}
		public static implicit operator NonDispatchable(DynamicDsState namicdsstate)
		{
			return new NonDispatchable(namicdsstate.Handle);
		}
		
		public static explicit operator DynamicDsState(NonDispatchable ndispatchable)
		{
			return new DynamicDsState(ndispatchable.Handle);
		}
		public static implicit operator Object(DynamicDsState namicdsstate)
		{
			return new Object(namicdsstate.Handle);
		}
		
		public static explicit operator DynamicDsState(Object ject)
		{
			return new DynamicDsState(ject.Handle);
		}
	
	}
	public struct Fence
	{
		internal Int64 Handle;

		public Fence(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Fence nce)
		{
			return new NonDispatchable(nce.Handle);
		}
		
		public static explicit operator Fence(NonDispatchable ndispatchable)
		{
			return new Fence(ndispatchable.Handle);
		}
		public static implicit operator Object(Fence nce)
		{
			return new Object(nce.Handle);
		}
		
		public static explicit operator Fence(Object ject)
		{
			return new Fence(ject.Handle);
		}
	
	}
	public struct Semaphore
	{
		internal Int64 Handle;

		public Semaphore(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Semaphore maphore)
		{
			return new NonDispatchable(maphore.Handle);
		}
		
		public static explicit operator Semaphore(NonDispatchable ndispatchable)
		{
			return new Semaphore(ndispatchable.Handle);
		}
		public static implicit operator Object(Semaphore maphore)
		{
			return new Object(maphore.Handle);
		}
		
		public static explicit operator Semaphore(Object ject)
		{
			return new Semaphore(ject.Handle);
		}
	
	}
	public struct Event
	{
		internal Int64 Handle;

		public Event(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Event ent)
		{
			return new NonDispatchable(ent.Handle);
		}
		
		public static explicit operator Event(NonDispatchable ndispatchable)
		{
			return new Event(ndispatchable.Handle);
		}
		public static implicit operator Object(Event ent)
		{
			return new Object(ent.Handle);
		}
		
		public static explicit operator Event(Object ject)
		{
			return new Event(ject.Handle);
		}
	
	}
	public struct QueryPool
	{
		internal Int64 Handle;

		public QueryPool(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(QueryPool erypool)
		{
			return new NonDispatchable(erypool.Handle);
		}
		
		public static explicit operator QueryPool(NonDispatchable ndispatchable)
		{
			return new QueryPool(ndispatchable.Handle);
		}
		public static implicit operator Object(QueryPool erypool)
		{
			return new Object(erypool.Handle);
		}
		
		public static explicit operator QueryPool(Object ject)
		{
			return new QueryPool(ject.Handle);
		}
	
	}
	public struct Framebuffer
	{
		internal Int64 Handle;

		public Framebuffer(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(Framebuffer amebuffer)
		{
			return new NonDispatchable(amebuffer.Handle);
		}
		
		public static explicit operator Framebuffer(NonDispatchable ndispatchable)
		{
			return new Framebuffer(ndispatchable.Handle);
		}
		public static implicit operator Object(Framebuffer amebuffer)
		{
			return new Object(amebuffer.Handle);
		}
		
		public static explicit operator Framebuffer(Object ject)
		{
			return new Framebuffer(ject.Handle);
		}
	
	}
	public struct RenderPass
	{
		internal Int64 Handle;

		public RenderPass(Int64 handle)
		{
			Handle = handle;
		}
		public static implicit operator NonDispatchable(RenderPass nderpass)
		{
			return new NonDispatchable(nderpass.Handle);
		}
		
		public static explicit operator RenderPass(NonDispatchable ndispatchable)
		{
			return new RenderPass(ndispatchable.Handle);
		}
		public static implicit operator Object(RenderPass nderpass)
		{
			return new Object(nderpass.Handle);
		}
		
		public static explicit operator RenderPass(Object ject)
		{
			return new RenderPass(ject.Handle);
		}
	
	}
}

