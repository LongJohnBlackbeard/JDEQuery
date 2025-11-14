using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R13 - .
/// </summary>
public class F40R13 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DPDEID.
        /// </summary>
        public const string DPDEID = "DPDEID";

        /// <summary>
        /// DPDMDPKGS.
        /// </summary>
        public const string DPDMDPKGS = "DPDMDPKGS";

        /// <summary>
        /// DPPKGCD.
        /// </summary>
        public const string DPPKGCD = "DPPKGCD";

        /// <summary>
        /// DPRETCONT.
        /// </summary>
        public const string DPRETCONT = "DPRETCONT";

        /// <summary>
        /// DPSTPK.
        /// </summary>
        public const string DPSTPK = "DPSTPK";

        /// <summary>
        /// DPUOM.
        /// </summary>
        public const string DPUOM = "DPUOM";

        /// <summary>
        /// DPPKGWT.
        /// </summary>
        public const string DPPKGWT = "DPPKGWT";

        /// <summary>
        /// DPPKGWTUOM.
        /// </summary>
        public const string DPPKGWTUOM = "DPPKGWTUOM";

        /// <summary>
        /// DPTYPPKGID.
        /// </summary>
        public const string DPTYPPKGID = "DPTYPPKGID";

        /// <summary>
        /// DPURCD.
        /// </summary>
        public const string DPURCD = "DPURCD";

        /// <summary>
        /// DPURDT.
        /// </summary>
        public const string DPURDT = "DPURDT";

        /// <summary>
        /// DPURAT.
        /// </summary>
        public const string DPURAT = "DPURAT";

        /// <summary>
        /// DPURAB.
        /// </summary>
        public const string DPURAB = "DPURAB";

        /// <summary>
        /// DPURRF.
        /// </summary>
        public const string DPURRF = "DPURRF";

        /// <summary>
        /// DPUSER.
        /// </summary>
        public const string DPUSER = "DPUSER";

        /// <summary>
        /// DPPID.
        /// </summary>
        public const string DPPID = "DPPID";

        /// <summary>
        /// DPJOBN.
        /// </summary>
        public const string DPJOBN = "DPJOBN";

        /// <summary>
        /// DPUPMJ.
        /// </summary>
        public const string DPUPMJ = "DPUPMJ";

        /// <summary>
        /// DPTDAY.
        /// </summary>
        public const string DPTDAY = "DPTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R13";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DPDEID", "DPDEID", JdeDataType.Numeric, null, true, true),
        new JdeField("DPDMDPKGS", "DPDMDPKGS", JdeDataType.Numeric),
        new JdeField("DPPKGCD", "DPPKGCD", JdeDataType.String, 34),
        new JdeField("DPRETCONT", "DPRETCONT", JdeDataType.String, 70),
        new JdeField("DPSTPK", "DPSTPK", JdeDataType.Numeric),
        new JdeField("DPUOM", "DPUOM", JdeDataType.String, 4),
        new JdeField("DPPKGWT", "DPPKGWT", JdeDataType.Numeric),
        new JdeField("DPPKGWTUOM", "DPPKGWTUOM", JdeDataType.String, 6),
        new JdeField("DPTYPPKGID", "DPTYPPKGID", JdeDataType.String, 34),
        new JdeField("DPURCD", "DPURCD", JdeDataType.String, 4),
        new JdeField("DPURDT", "DPURDT", JdeDataType.Numeric),
        new JdeField("DPURAT", "DPURAT", JdeDataType.Numeric),
        new JdeField("DPURAB", "DPURAB", JdeDataType.Numeric),
        new JdeField("DPURRF", "DPURRF", JdeDataType.String, 30),
        new JdeField("DPUSER", "DPUSER", JdeDataType.String, 20),
        new JdeField("DPPID", "DPPID", JdeDataType.String, 20),
        new JdeField("DPJOBN", "DPJOBN", JdeDataType.String, 20),
        new JdeField("DPUPMJ", "DPUPMJ", JdeDataType.Numeric),
        new JdeField("DPTDAY", "DPTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R13_0", "Primary Key on DPDEID", new[] { "DPDEID" }, isUnique: true, isPrimaryKey: true)
    };
}
