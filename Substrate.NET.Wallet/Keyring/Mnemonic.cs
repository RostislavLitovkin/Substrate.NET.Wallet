﻿using Substrate.NET.Wallet.Extensions;
using Substrate.NetApi.Model.Types;
using System;
using System.Collections.Generic;
using static Substrate.NetApi.Mnemonic;

namespace Substrate.NET.Wallet.Keyring
{
    public static class Mnemonic
    {

        //public enum MnemonicSize
        //{
        //    Words12,
        //    Words15,
        //    Words18,
        //    Words21,
        //    Words24
        //}

        ///// <summary>
        ///// Generate new mnemonic based on nb words
        ///// </summary>
        ///// <param name="mnemonicSize"></param>
        ///// <param name="bIP39Wordlist"></param>
        ///// <returns></returns>
        //public static string[] GenerateMnemonic(MnemonicSize mnemonicSize, BIP39Wordlist bIP39Wordlist = BIP39Wordlist.English)
        //{
        //    switch(mnemonicSize)
        //    {
        //        case MnemonicSize.Words12:
        //            return MnemonicFromEntropy(new byte[16].Populate(), bIP39Wordlist);
        //        case MnemonicSize.Words15:
        //            return MnemonicFromEntropy(new byte[20].Populate(), bIP39Wordlist);
        //        case MnemonicSize.Words18:
        //            return MnemonicFromEntropy(new byte[24].Populate(), bIP39Wordlist);
        //        case MnemonicSize.Words21:
        //            return MnemonicFromEntropy(new byte[28].Populate(), bIP39Wordlist);
        //        case MnemonicSize.Words24:
        //            return MnemonicFromEntropy(new byte[32].Populate(), bIP39Wordlist);
        //    }

        //    throw new InvalidOperationException("Invalid mnemonic size");
        //}

        //public static string GetUri(string mnemonic, string derivePath)
        //{
        //    // We don't handle (yet...)  KeyType ed25519-ledger and Ethereum
        //    return $"{mnemonic}{derivePath}";
        //}

        //public static byte[] MnemonicToMiniSecret(string mnemonic, string password, BIP39Wordlist bIP39Wordlist = BIP39Wordlist.English)
        //{
        //    if(!ValidateMnemonic(mnemonic, bIP39Wordlist))
        //    {
        //        throw new InvalidOperationException("Invalid bip39 mnemonic specified");
        //    }

        //    return GetSecretKeyFromMnemonic(mnemonic, password, bIP39Wordlist);
        //}

        //public static bool ValidateMnemonic(string mnemonic, BIP39Wordlist bIP39Wordlist = BIP39Wordlist.English)
        //{
        //    try
        //    {
        //        _ = MnemonicToEntropy(mnemonic, bIP39Wordlist);
        //        return true;
        //    } catch (Exception)
        //    {
        //        return false;
        //    }
        //}

        //public static PairInfo KeyFromPath(PairInfo pair, IEnumerable<DeriveJunction> path, KeyType keyType)
        //{
        //    // TODO : handle DeriveJunction
        //    return pair;
        //}
    }
}
