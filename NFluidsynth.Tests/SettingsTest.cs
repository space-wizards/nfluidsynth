﻿using NUnit.Framework;
using System;
using NFluidsynth;

namespace NFluidsynth.Tests
{
	[TestFixture]
	public class SettingsTest
	{
		[Test]
		public void Properties ()
		{
			var c = new Settings ();
			Assert.AreEqual (16, c [ConfigurationKeys.SynthMidiChannels].IntValue, ConfigurationKeys.SynthMidiChannels);
			Assert.AreEqual (1, c [ConfigurationKeys.SynthAudioChannels].IntValue, ConfigurationKeys.SynthAudioChannels);
			Assert.AreEqual ("jack", c [ConfigurationKeys.AudioDriver].StringValue, ConfigurationKeys.AudioDriver);
			Assert.AreEqual (0, c [ConfigurationKeys.SynthDeviceId].IntValue, ConfigurationKeys.SynthDeviceId);
			Assert.AreEqual (256, c [ConfigurationKeys.SynthPolyphony].IntValue, ConfigurationKeys.SynthPolyphony);
			c.Dispose ();
		}

        [Test]
        public void TestThrows()
        {
            var c = new Settings ();

            Assert.That(() => c["deadbeef"].StringValue = "foo", Throws.InstanceOf<FluidSynthInteropException>());
        }
	}
}
