using Encryption;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace ClientServer_Tests
{
    [TestClass]
    public class SpnEncryption_Test
    {
        [TestMethod]
        public void CanInstantiateSpnEncryption_WithAParameterizedConstructorMethod()
        {
            SPN_encryption encryption = new SPN_encryption("Baam");
        }

        [TestMethod]
        public void CanInstantiateSpnEncryption_WithTwoParameterizedConstructorMethod()
        {
            SPN_encryption encryption = new SPN_encryption("Baam", "Baam_Key");
        }

        [TestMethod]
        public void StringToBinary_ReturnTrue()
        {
            // Arange
            SPN_encryption encryption = new SPN_encryption("Baam");
            
            // Act
            var result = encryption.stringToBinary("Ata");

            // Assert
            Assert.AreEqual(result, "010000010111010001100001");
        }

        [TestMethod]
        public void Encrypt_EncryptThePlainText_ReturnTrue()
        {
            // Arange
            SPN_encryption encryption = new SPN_encryption("Baam","Baam_Key");

            // Act
            var result = encryption.encrypt();

            // Assert
            Assert.AreEqual(result, "10010010010101010001010011110101");
        }

        [TestMethod]
        public void decrypt_DecryptingEncryptedPlainText_ReturnTrue()
        {
            // Arange
            SPN_encryption encryption = new SPN_encryption("Baam", "Baam_Key");
            
            // Act
            var value = encryption.encrypt();
            var result = encryption.decrypt(value);

            // Assert
            Assert.AreEqual(result, "Baam");
        }
    }
}
