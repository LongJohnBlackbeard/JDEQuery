using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F087711 - .
/// </summary>
public class F087711 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// XJTINC.
        /// </summary>
        public const string XJTINC = "XJTINC";

        /// <summary>
        /// XJANPA.
        /// </summary>
        public const string XJANPA = "XJANPA";

        /// <summary>
        /// XJAN8.
        /// </summary>
        public const string XJAN8 = "XJAN8";

        /// <summary>
        /// XJDEF.
        /// </summary>
        public const string XJDEF = "XJDEF";

        /// <summary>
        /// XJGAPS.
        /// </summary>
        public const string XJGAPS = "XJGAPS";

        /// <summary>
        /// XJFRVW.
        /// </summary>
        public const string XJFRVW = "XJFRVW";

        /// <summary>
        /// XJTRVW.
        /// </summary>
        public const string XJTRVW = "XJTRVW";

        /// <summary>
        /// XJPADD.
        /// </summary>
        public const string XJPADD = "XJPADD";

        /// <summary>
        /// XJESADD.
        /// </summary>
        public const string XJESADD = "XJESADD";

        /// <summary>
        /// XJOTPS.
        /// </summary>
        public const string XJOTPS = "XJOTPS";

        /// <summary>
        /// XJORMCU.
        /// </summary>
        public const string XJORMCU = "XJORMCU";

        /// <summary>
        /// XJPOS.
        /// </summary>
        public const string XJPOS = "XJPOS";

        /// <summary>
        /// XJNPDL01.
        /// </summary>
        public const string XJNPDL01 = "XJNPDL01";

        /// <summary>
        /// XJJGRP.
        /// </summary>
        public const string XJJGRP = "XJJGRP";

        /// <summary>
        /// XJJBCD.
        /// </summary>
        public const string XJJBCD = "XJJBCD";

        /// <summary>
        /// XJJBST.
        /// </summary>
        public const string XJJBST = "XJJBST";

        /// <summary>
        /// XJDESCJTS.
        /// </summary>
        public const string XJDESCJTS = "XJDESCJTS";

        /// <summary>
        /// XJJBCX.
        /// </summary>
        public const string XJJBCX = "XJJBCX";

        /// <summary>
        /// XJCPDT.
        /// </summary>
        public const string XJCPDT = "XJCPDT";

        /// <summary>
        /// XJCDIJ.
        /// </summary>
        public const string XJCDIJ = "XJCDIJ";

        /// <summary>
        /// XJDST.
        /// </summary>
        public const string XJDST = "XJDST";

        /// <summary>
        /// XJSAPL.
        /// </summary>
        public const string XJSAPL = "XJSAPL";

        /// <summary>
        /// XJSAPLDS.
        /// </summary>
        public const string XJSAPLDS = "XJSAPLDS";

        /// <summary>
        /// XJNCMPV.
        /// </summary>
        public const string XJNCMPV = "XJNCMPV";

        /// <summary>
        /// XJNCMPDS.
        /// </summary>
        public const string XJNCMPDS = "XJNCMPDS";

        /// <summary>
        /// XJPAPL.
        /// </summary>
        public const string XJPAPL = "XJPAPL";

        /// <summary>
        /// XJPAPLDS.
        /// </summary>
        public const string XJPAPLDS = "XJPAPLDS";

        /// <summary>
        /// XJPACM.
        /// </summary>
        public const string XJPACM = "XJPACM";

        /// <summary>
        /// XJSCLES.
        /// </summary>
        public const string XJSCLES = "XJSCLES";

        /// <summary>
        /// XJREQLS.
        /// </summary>
        public const string XJREQLS = "XJREQLS";

        /// <summary>
        /// XJRQSDS.
        /// </summary>
        public const string XJRQSDS = "XJRQSDS";

        /// <summary>
        /// XJESARQ.
        /// </summary>
        public const string XJESARQ = "XJESARQ";

        /// <summary>
        /// XJPABM.
        /// </summary>
        public const string XJPABM = "XJPABM";

        /// <summary>
        /// XJESAS.
        /// </summary>
        public const string XJESAS = "XJESAS";

        /// <summary>
        /// XJSCLEE.
        /// </summary>
        public const string XJSCLEE = "XJSCLEE";

        /// <summary>
        /// XJREQLE.
        /// </summary>
        public const string XJREQLE = "XJREQLE";

        /// <summary>
        /// XJRQEDS.
        /// </summary>
        public const string XJRQEDS = "XJRQEDS";

        /// <summary>
        /// XJPASTA.
        /// </summary>
        public const string XJPASTA = "XJPASTA";

        /// <summary>
        /// XJAPPST.
        /// </summary>
        public const string XJAPPST = "XJAPPST";

        /// <summary>
        /// XJANAB.
        /// </summary>
        public const string XJANAB = "XJANAB";

        /// <summary>
        /// XJLVEL.
        /// </summary>
        public const string XJLVEL = "XJLVEL";

        /// <summary>
        /// XJLARD.
        /// </summary>
        public const string XJLARD = "XJLARD";

        /// <summary>
        /// XJSERK.
        /// </summary>
        public const string XJSERK = "XJSERK";

        /// <summary>
        /// XJTORG.
        /// </summary>
        public const string XJTORG = "XJTORG";

        /// <summary>
        /// XJUSER.
        /// </summary>
        public const string XJUSER = "XJUSER";

        /// <summary>
        /// XJPID.
        /// </summary>
        public const string XJPID = "XJPID";

        /// <summary>
        /// XJJOBN.
        /// </summary>
        public const string XJJOBN = "XJJOBN";

        /// <summary>
        /// XJUPMJ.
        /// </summary>
        public const string XJUPMJ = "XJUPMJ";

        /// <summary>
        /// XJUPMT.
        /// </summary>
        public const string XJUPMT = "XJUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F087711";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("XJTINC", "XJTINC", JdeDataType.String, 2, true, true),
        new JdeField("XJANPA", "XJANPA", JdeDataType.Numeric, null, true, true),
        new JdeField("XJAN8", "XJAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("XJDEF", "XJDEF", JdeDataType.Numeric, null, true, true),
        new JdeField("XJGAPS", "XJGAPS", JdeDataType.String, 6),
        new JdeField("XJFRVW", "XJFRVW", JdeDataType.Numeric),
        new JdeField("XJTRVW", "XJTRVW", JdeDataType.Numeric),
        new JdeField("XJPADD", "XJPADD", JdeDataType.Numeric),
        new JdeField("XJESADD", "XJESADD", JdeDataType.Numeric),
        new JdeField("XJOTPS", "XJOTPS", JdeDataType.String, 6),
        new JdeField("XJORMCU", "XJORMCU", JdeDataType.String, 24),
        new JdeField("XJPOS", "XJPOS", JdeDataType.String, 16),
        new JdeField("XJNPDL01", "XJNPDL01", JdeDataType.String, 60),
        new JdeField("XJJGRP", "XJJGRP", JdeDataType.String, 12),
        new JdeField("XJJBCD", "XJJBCD", JdeDataType.String, 12),
        new JdeField("XJJBST", "XJJBST", JdeDataType.String, 8),
        new JdeField("XJDESCJTS", "XJDESCJTS", JdeDataType.String, 60),
        new JdeField("XJJBCX", "XJJBCX", JdeDataType.String, 60),
        new JdeField("XJCPDT", "XJCPDT", JdeDataType.Numeric),
        new JdeField("XJCDIJ", "XJCDIJ", JdeDataType.Numeric),
        new JdeField("XJDST", "XJDST", JdeDataType.Numeric),
        new JdeField("XJSAPL", "XJSAPL", JdeDataType.Numeric),
        new JdeField("XJSAPLDS", "XJSAPLDS", JdeDataType.String, 60),
        new JdeField("XJNCMPV", "XJNCMPV", JdeDataType.Numeric),
        new JdeField("XJNCMPDS", "XJNCMPDS", JdeDataType.String, 60),
        new JdeField("XJPAPL", "XJPAPL", JdeDataType.Numeric),
        new JdeField("XJPAPLDS", "XJPAPLDS", JdeDataType.String, 60),
        new JdeField("XJPACM", "XJPACM", JdeDataType.String, 2),
        new JdeField("XJSCLES", "XJSCLES", JdeDataType.String, 20),
        new JdeField("XJREQLS", "XJREQLS", JdeDataType.Numeric),
        new JdeField("XJRQSDS", "XJRQSDS", JdeDataType.String, 60),
        new JdeField("XJESARQ", "XJESARQ", JdeDataType.String, 2),
        new JdeField("XJPABM", "XJPABM", JdeDataType.String, 2),
        new JdeField("XJESAS", "XJESAS", JdeDataType.String, 6),
        new JdeField("XJSCLEE", "XJSCLEE", JdeDataType.String, 20),
        new JdeField("XJREQLE", "XJREQLE", JdeDataType.Numeric),
        new JdeField("XJRQEDS", "XJRQEDS", JdeDataType.String, 60),
        new JdeField("XJPASTA", "XJPASTA", JdeDataType.String, 2),
        new JdeField("XJAPPST", "XJAPPST", JdeDataType.String, 2),
        new JdeField("XJANAB", "XJANAB", JdeDataType.Numeric),
        new JdeField("XJLVEL", "XJLVEL", JdeDataType.Numeric),
        new JdeField("XJLARD", "XJLARD", JdeDataType.Numeric),
        new JdeField("XJSERK", "XJSERK", JdeDataType.Numeric, null, true, true),
        new JdeField("XJTORG", "XJTORG", JdeDataType.String, 20),
        new JdeField("XJUSER", "XJUSER", JdeDataType.String, 20),
        new JdeField("XJPID", "XJPID", JdeDataType.String, 20),
        new JdeField("XJJOBN", "XJJOBN", JdeDataType.String, 20),
        new JdeField("XJUPMJ", "XJUPMJ", JdeDataType.Numeric),
        new JdeField("XJUPMT", "XJUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F087711_0", "Primary Key on XJTINC, XJANPA, XJAN8, XJDEF, XJSERK", new[] { "XJTINC", "XJANPA", "XJAN8", "XJDEF", "XJSERK" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F087711_2", "Index on SYS_NC00050$", new[] { "SYS_NC00050$" }),
        new JdeIndex("F087711_3", "Index on XJTINC, XJANPA, XJAN8, XJDEF", new[] { "XJTINC", "XJANPA", "XJAN8", "XJDEF" }),
        new JdeIndex("F087711_4", "Index on XJTINC, XJAN8, XJDEF", new[] { "XJTINC", "XJAN8", "XJDEF" })
    };
}
