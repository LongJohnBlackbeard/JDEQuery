using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F15301 - .
/// </summary>
public class F15301 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// AOEPCL.
        /// </summary>
        public const string AOEPCL = "AOEPCL";

        /// <summary>
        /// AOMCU.
        /// </summary>
        public const string AOMCU = "AOMCU";

        /// <summary>
        /// AOOBJ.
        /// </summary>
        public const string AOOBJ = "AOOBJ";

        /// <summary>
        /// AOSUB.
        /// </summary>
        public const string AOSUB = "AOSUB";

        /// <summary>
        /// AOEFTB.
        /// </summary>
        public const string AOEFTB = "AOEFTB";

        /// <summary>
        /// AOEFTE.
        /// </summary>
        public const string AOEFTE = "AOEFTE";

        /// <summary>
        /// AOEPMCU.
        /// </summary>
        public const string AOEPMCU = "AOEPMCU";

        /// <summary>
        /// AOMCUSEC.
        /// </summary>
        public const string AOMCUSEC = "AOMCUSEC";

        /// <summary>
        /// AOAID.
        /// </summary>
        public const string AOAID = "AOAID";

        /// <summary>
        /// AOSTGU.
        /// </summary>
        public const string AOSTGU = "AOSTGU";

        /// <summary>
        /// AOVPCTGU.
        /// </summary>
        public const string AOVPCTGU = "AOVPCTGU";

        /// <summary>
        /// AOOCTYPE.
        /// </summary>
        public const string AOOCTYPE = "AOOCTYPE";

        /// <summary>
        /// AOGPCT.
        /// </summary>
        public const string AOGPCT = "AOGPCT";

        /// <summary>
        /// AOEXFR.
        /// </summary>
        public const string AOEXFR = "AOEXFR";

        /// <summary>
        /// AOELRD.
        /// </summary>
        public const string AOELRD = "AOELRD";

        /// <summary>
        /// AOBRAD.
        /// </summary>
        public const string AOBRAD = "AOBRAD";

        /// <summary>
        /// AOFERT.
        /// </summary>
        public const string AOFERT = "AOFERT";

        /// <summary>
        /// AOFEBS.
        /// </summary>
        public const string AOFEBS = "AOFEBS";

        /// <summary>
        /// AOEFAF.
        /// </summary>
        public const string AOEFAF = "AOEFAF";

        /// <summary>
        /// AOSTCAP.
        /// </summary>
        public const string AOSTCAP = "AOSTCAP";

        /// <summary>
        /// AOCLAF.
        /// </summary>
        public const string AOCLAF = "AOCLAF";

        /// <summary>
        /// AOAFPL.
        /// </summary>
        public const string AOAFPL = "AOAFPL";

        /// <summary>
        /// AOLTGRP.
        /// </summary>
        public const string AOLTGRP = "AOLTGRP";

        /// <summary>
        /// AORMK.
        /// </summary>
        public const string AORMK = "AORMK";

        /// <summary>
        /// AOURCD.
        /// </summary>
        public const string AOURCD = "AOURCD";

        /// <summary>
        /// AOURDT.
        /// </summary>
        public const string AOURDT = "AOURDT";

        /// <summary>
        /// AOURAT.
        /// </summary>
        public const string AOURAT = "AOURAT";

        /// <summary>
        /// AOURAB.
        /// </summary>
        public const string AOURAB = "AOURAB";

        /// <summary>
        /// AOURRF.
        /// </summary>
        public const string AOURRF = "AOURRF";

        /// <summary>
        /// AOUSER.
        /// </summary>
        public const string AOUSER = "AOUSER";

        /// <summary>
        /// AOPID.
        /// </summary>
        public const string AOPID = "AOPID";

        /// <summary>
        /// AOMKEY.
        /// </summary>
        public const string AOMKEY = "AOMKEY";

        /// <summary>
        /// AOUPMJ.
        /// </summary>
        public const string AOUPMJ = "AOUPMJ";

        /// <summary>
        /// AOUPMT.
        /// </summary>
        public const string AOUPMT = "AOUPMT";

        /// <summary>
        /// AOTORG.
        /// </summary>
        public const string AOTORG = "AOTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F15301";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("AOEPCL", "AOEPCL", JdeDataType.String, 8, true, true),
        new JdeField("AOMCU", "AOMCU", JdeDataType.String, 24, true, true),
        new JdeField("AOOBJ", "AOOBJ", JdeDataType.String, 12, true, true),
        new JdeField("AOSUB", "AOSUB", JdeDataType.String, 16, true, true),
        new JdeField("AOEFTB", "AOEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("AOEFTE", "AOEFTE", JdeDataType.Numeric, null, true, true),
        new JdeField("AOEPMCU", "AOEPMCU", JdeDataType.String, 24, true, true),
        new JdeField("AOMCUSEC", "AOMCUSEC", JdeDataType.String, 24),
        new JdeField("AOAID", "AOAID", JdeDataType.String, 16),
        new JdeField("AOSTGU", "AOSTGU", JdeDataType.String, 2),
        new JdeField("AOVPCTGU", "AOVPCTGU", JdeDataType.Numeric),
        new JdeField("AOOCTYPE", "AOOCTYPE", JdeDataType.String, 2),
        new JdeField("AOGPCT", "AOGPCT", JdeDataType.Numeric),
        new JdeField("AOEXFR", "AOEXFR", JdeDataType.String, 2),
        new JdeField("AOELRD", "AOELRD", JdeDataType.String, 2),
        new JdeField("AOBRAD", "AOBRAD", JdeDataType.String, 8),
        new JdeField("AOFERT", "AOFERT", JdeDataType.Numeric),
        new JdeField("AOFEBS", "AOFEBS", JdeDataType.String, 2),
        new JdeField("AOEFAF", "AOEFAF", JdeDataType.String, 2),
        new JdeField("AOSTCAP", "AOSTCAP", JdeDataType.String, 2),
        new JdeField("AOCLAF", "AOCLAF", JdeDataType.Numeric),
        new JdeField("AOAFPL", "AOAFPL", JdeDataType.String, 2),
        new JdeField("AOLTGRP", "AOLTGRP", JdeDataType.String, 30),
        new JdeField("AORMK", "AORMK", JdeDataType.String, 60),
        new JdeField("AOURCD", "AOURCD", JdeDataType.String, 4),
        new JdeField("AOURDT", "AOURDT", JdeDataType.Numeric),
        new JdeField("AOURAT", "AOURAT", JdeDataType.Numeric),
        new JdeField("AOURAB", "AOURAB", JdeDataType.Numeric),
        new JdeField("AOURRF", "AOURRF", JdeDataType.String, 30),
        new JdeField("AOUSER", "AOUSER", JdeDataType.String, 20),
        new JdeField("AOPID", "AOPID", JdeDataType.String, 20),
        new JdeField("AOMKEY", "AOMKEY", JdeDataType.String, 30),
        new JdeField("AOUPMJ", "AOUPMJ", JdeDataType.Numeric),
        new JdeField("AOUPMT", "AOUPMT", JdeDataType.Numeric),
        new JdeField("AOTORG", "AOTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F15301_0", "Primary Key on AOEPCL, AOMCU, AOOBJ, AOSUB, AOEPMCU, AOEFTB, AOEFTE", new[] { "AOEPCL", "AOMCU", "AOOBJ", "AOSUB", "AOEPMCU", "AOEFTB", "AOEFTE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F15301_2", "Index on AOEPCL, AOMCU, AOOBJ, AOSUB, AOEPMCU", new[] { "AOEPCL", "AOMCU", "AOOBJ", "AOSUB", "AOEPMCU" })
    };
}
