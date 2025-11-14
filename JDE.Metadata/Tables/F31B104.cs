using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B104 - .
/// </summary>
public class F31B104 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPNCOBNM.
        /// </summary>
        public const string DPNCOBNM = "DPNCOBNM";

        /// <summary>
        /// DPUGRP.
        /// </summary>
        public const string DPUGRP = "DPUGRP";

        /// <summary>
        /// DPNCOBJP1.
        /// </summary>
        public const string DPNCOBJP1 = "DPNCOBJP1";

        /// <summary>
        /// DPNCOBJP2.
        /// </summary>
        public const string DPNCOBJP2 = "DPNCOBJP2";

        /// <summary>
        /// DPNCPATHID.
        /// </summary>
        public const string DPNCPATHID = "DPNCPATHID";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURAT.
        /// </summary>
        public const string DPURAT = "DPURAT";

        /// <summary>
        /// DPURCD.
        /// </summary>
        public const string DPURCD = "DPURCD";

        /// <summary>
        /// DPURDT.
        /// </summary>
        public const string DPURDT = "DPURDT";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPWAB.
        /// </summary>
        public const string DPWAB = "DPWAB";

        /// <summary>
        /// DPWNUM.
        /// </summary>
        public const string DPWNUM = "DPWNUM";

        /// <summary>
        /// DPWCD.
        /// </summary>
        public const string DPWCD = "DPWCD";

        /// <summary>
        /// DPWMDT.
        /// </summary>
        public const string DPWMDT = "DPWMDT";

        /// <summary>
        /// DPWRF.
        /// </summary>
        public const string DPWRF = "DPWRF";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPUPMT.
        /// </summary>
        public const string DPUPMT = "DPUPMT";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPMKEY.
        /// </summary>
        public const string DPMKEY = "DPMKEY";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";
    }

    /// <inheritdoc />
    public override string TableName => "F31B104";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPNCOBNM", "DPNCOBNM", JdeDataType.String, 20, true, true),
        new JdeField("DPUGRP", "DPUGRP", JdeDataType.String, 20, true, true),
        new JdeField("DPNCOBJP1", "DPNCOBJP1", JdeDataType.String, 20),
        new JdeField("DPNCOBJP2", "DPNCOBJP2", JdeDataType.String, 20),
        new JdeField("DPNCPATHID", "DPNCPATHID", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURAT", "DPURAT", JdeDataType.Numeric),
        new JdeField("DPURCD", "DPURCD", JdeDataType.String, 4),
        new JdeField("DPURDT", "DPURDT", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPWAB", "DPWAB", JdeDataType.Numeric),
        new JdeField("DPWNUM", "DPWNUM", JdeDataType.Numeric),
        new JdeField("DPWCD", "DPWCD", JdeDataType.String, 6),
        new JdeField("DPWMDT", "DPWMDT", JdeDataType.Numeric),
        new JdeField("DPWRF", "DPWRF", JdeDataType.String, 60),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPUPMT", "DPUPMT", JdeDataType.Numeric),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPMKEY", "DPMKEY", JdeDataType.String, 30),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B104_0", "Primary Key on DPNCOBNM, DPUGRP", new[] { "DPNCOBNM", "DPUGRP" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B104_2", "Index on DPNCPATHID", new[] { "DPNCPATHID" })
    };
}
