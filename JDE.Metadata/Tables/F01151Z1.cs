using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01151Z1 - .
/// </summary>
public class F01151Z1 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EBEDUS.
        /// </summary>
        public const string EBEDUS = "EBEDUS";

        /// <summary>
        /// EBEDBT.
        /// </summary>
        public const string EBEDBT = "EBEDBT";

        /// <summary>
        /// EBEDTN.
        /// </summary>
        public const string EBEDTN = "EBEDTN";

        /// <summary>
        /// EBEDLN.
        /// </summary>
        public const string EBEDLN = "EBEDLN";

        /// <summary>
        /// EBEDCT.
        /// </summary>
        public const string EBEDCT = "EBEDCT";

        /// <summary>
        /// EBTYTN.
        /// </summary>
        public const string EBTYTN = "EBTYTN";

        /// <summary>
        /// EBEDFT.
        /// </summary>
        public const string EBEDFT = "EBEDFT";

        /// <summary>
        /// EBEDDT.
        /// </summary>
        public const string EBEDDT = "EBEDDT";

        /// <summary>
        /// EBDRIN.
        /// </summary>
        public const string EBDRIN = "EBDRIN";

        /// <summary>
        /// EBEDDL.
        /// </summary>
        public const string EBEDDL = "EBEDDL";

        /// <summary>
        /// EBEDSP.
        /// </summary>
        public const string EBEDSP = "EBEDSP";

        /// <summary>
        /// EBPNID.
        /// </summary>
        public const string EBPNID = "EBPNID";

        /// <summary>
        /// EBTNAC.
        /// </summary>
        public const string EBTNAC = "EBTNAC";

        /// <summary>
        /// EBAN8.
        /// </summary>
        public const string EBAN8 = "EBAN8";

        /// <summary>
        /// EBIDLN.
        /// </summary>
        public const string EBIDLN = "EBIDLN";

        /// <summary>
        /// EBRCK7.
        /// </summary>
        public const string EBRCK7 = "EBRCK7";

        /// <summary>
        /// EBETP.
        /// </summary>
        public const string EBETP = "EBETP";

        /// <summary>
        /// EBEMAL.
        /// </summary>
        public const string EBEMAL = "EBEMAL";

        /// <summary>
        /// EBTORG.
        /// </summary>
        public const string EBTORG = "EBTORG";

        /// <summary>
        /// EBUSER.
        /// </summary>
        public const string EBUSER = "EBUSER";

        /// <summary>
        /// EBPID.
        /// </summary>
        public const string EBPID = "EBPID";

        /// <summary>
        /// EBUPMJ.
        /// </summary>
        public const string EBUPMJ = "EBUPMJ";

        /// <summary>
        /// EBJOBN.
        /// </summary>
        public const string EBJOBN = "EBJOBN";

        /// <summary>
        /// EBTDAY.
        /// </summary>
        public const string EBTDAY = "EBTDAY";

        /// <summary>
        /// EBUPMT.
        /// </summary>
        public const string EBUPMT = "EBUPMT";

        /// <summary>
        /// EBEFOR.
        /// </summary>
        public const string EBEFOR = "EBEFOR";

        /// <summary>
        /// EBEHIER.
        /// </summary>
        public const string EBEHIER = "EBEHIER";

        /// <summary>
        /// EBECLASS.
        /// </summary>
        public const string EBECLASS = "EBECLASS";

        /// <summary>
        /// EBCFNO1.
        /// </summary>
        public const string EBCFNO1 = "EBCFNO1";

        /// <summary>
        /// EBGEN1.
        /// </summary>
        public const string EBGEN1 = "EBGEN1";

        /// <summary>
        /// EBFALGE.
        /// </summary>
        public const string EBFALGE = "EBFALGE";
    }

    /// <inheritdoc />
    public override string TableName => "F01151Z1";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EBEDUS", "EBEDUS", JdeDataType.String, 20, true, true),
        new JdeField("EBEDBT", "EBEDBT", JdeDataType.String, 30, true, true),
        new JdeField("EBEDTN", "EBEDTN", JdeDataType.String, 44, true, true),
        new JdeField("EBEDLN", "EBEDLN", JdeDataType.Numeric, null, true, true),
        new JdeField("EBEDCT", "EBEDCT", JdeDataType.String, 4),
        new JdeField("EBTYTN", "EBTYTN", JdeDataType.String, 16),
        new JdeField("EBEDFT", "EBEDFT", JdeDataType.String, 20),
        new JdeField("EBEDDT", "EBEDDT", JdeDataType.Numeric),
        new JdeField("EBDRIN", "EBDRIN", JdeDataType.String, 2),
        new JdeField("EBEDDL", "EBEDDL", JdeDataType.Numeric),
        new JdeField("EBEDSP", "EBEDSP", JdeDataType.String, 2),
        new JdeField("EBPNID", "EBPNID", JdeDataType.String, 30),
        new JdeField("EBTNAC", "EBTNAC", JdeDataType.String, 4),
        new JdeField("EBAN8", "EBAN8", JdeDataType.Numeric),
        new JdeField("EBIDLN", "EBIDLN", JdeDataType.Numeric),
        new JdeField("EBRCK7", "EBRCK7", JdeDataType.Numeric),
        new JdeField("EBETP", "EBETP", JdeDataType.String, 8),
        new JdeField("EBEMAL", "EBEMAL", JdeDataType.String, 512),
        new JdeField("EBTORG", "EBTORG", JdeDataType.String, 20),
        new JdeField("EBUSER", "EBUSER", JdeDataType.String, 20),
        new JdeField("EBPID", "EBPID", JdeDataType.String, 20),
        new JdeField("EBUPMJ", "EBUPMJ", JdeDataType.Numeric),
        new JdeField("EBJOBN", "EBJOBN", JdeDataType.String, 20),
        new JdeField("EBTDAY", "EBTDAY", JdeDataType.Numeric),
        new JdeField("EBUPMT", "EBUPMT", JdeDataType.Numeric),
        new JdeField("EBEFOR", "EBEFOR", JdeDataType.String, 30),
        new JdeField("EBEHIER", "EBEHIER", JdeDataType.Numeric),
        new JdeField("EBECLASS", "EBECLASS", JdeDataType.String, 6),
        new JdeField("EBCFNO1", "EBCFNO1", JdeDataType.Numeric),
        new JdeField("EBGEN1", "EBGEN1", JdeDataType.String, 20),
        new JdeField("EBFALGE", "EBFALGE", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01151Z1_0", "Primary Key on EBEDUS, EBEDBT, EBEDTN, EBEDLN", new[] { "EBEDUS", "EBEDBT", "EBEDTN", "EBEDLN" }, isUnique: true, isPrimaryKey: true)
    };
}
