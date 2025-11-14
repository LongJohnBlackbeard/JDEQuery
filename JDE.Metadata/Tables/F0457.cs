using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0457 - .
/// </summary>
public class F0457 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// KMFILE.
        /// </summary>
        public const string KMFILE = "KMFILE";

        /// <summary>
        /// KMMID.
        /// </summary>
        public const string KMMID = "KMMID";

        /// <summary>
        /// KMGLBA.
        /// </summary>
        public const string KMGLBA = "KMGLBA";

        /// <summary>
        /// KMPID.
        /// </summary>
        public const string KMPID = "KMPID";

        /// <summary>
        /// KMUSER.
        /// </summary>
        public const string KMUSER = "KMUSER";

        /// <summary>
        /// KMUPMJ.
        /// </summary>
        public const string KMUPMJ = "KMUPMJ";

        /// <summary>
        /// KMUPMT.
        /// </summary>
        public const string KMUPMT = "KMUPMT";

        /// <summary>
        /// KMUSRC.
        /// </summary>
        public const string KMUSRC = "KMUSRC";

        /// <summary>
        /// KMTIMC.
        /// </summary>
        public const string KMTIMC = "KMTIMC";

        /// <summary>
        /// KMUPMC.
        /// </summary>
        public const string KMUPMC = "KMUPMC";

        /// <summary>
        /// KMFNAM.
        /// </summary>
        public const string KMFNAM = "KMFNAM";

        /// <summary>
        /// KMDEV.
        /// </summary>
        public const string KMDEV = "KMDEV";

        /// <summary>
        /// KMTDEN.
        /// </summary>
        public const string KMTDEN = "KMTDEN";

        /// <summary>
        /// KMLBN.
        /// </summary>
        public const string KMLBN = "KMLBN";

        /// <summary>
        /// KMRECL.
        /// </summary>
        public const string KMRECL = "KMRECL";

        /// <summary>
        /// KMBLK.
        /// </summary>
        public const string KMBLK = "KMBLK";

        /// <summary>
        /// KMNVOL.
        /// </summary>
        public const string KMNVOL = "KMNVOL";

        /// <summary>
        /// KMNOWN.
        /// </summary>
        public const string KMNOWN = "KMNOWN";

        /// <summary>
        /// KMBACS.
        /// </summary>
        public const string KMBACS = "KMBACS";

        /// <summary>
        /// KMPTPE.
        /// </summary>
        public const string KMPTPE = "KMPTPE";

        /// <summary>
        /// KMAA.
        /// </summary>
        public const string KMAA = "KMAA";

        /// <summary>
        /// KMBPDJ.
        /// </summary>
        public const string KMBPDJ = "KMBPDJ";

        /// <summary>
        /// KMBXDJ.
        /// </summary>
        public const string KMBXDJ = "KMBXDJ";

        /// <summary>
        /// KMBARP.
        /// </summary>
        public const string KMBARP = "KMBARP";

        /// <summary>
        /// KMGFL3.
        /// </summary>
        public const string KMGFL3 = "KMGFL3";

        /// <summary>
        /// KMGFL4.
        /// </summary>
        public const string KMGFL4 = "KMGFL4";
    }

    /// <inheritdoc />
    public override string TableName => "F0457";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("KMFILE", "KMFILE", JdeDataType.String, 20, true, true),
        new JdeField("KMMID", "KMMID", JdeDataType.String, 20, true, true),
        new JdeField("KMGLBA", "KMGLBA", JdeDataType.String, 16),
        new JdeField("KMPID", "KMPID", JdeDataType.String, 20),
        new JdeField("KMUSER", "KMUSER", JdeDataType.String, 20),
        new JdeField("KMUPMJ", "KMUPMJ", JdeDataType.Numeric),
        new JdeField("KMUPMT", "KMUPMT", JdeDataType.Numeric),
        new JdeField("KMUSRC", "KMUSRC", JdeDataType.String, 20),
        new JdeField("KMTIMC", "KMTIMC", JdeDataType.Numeric),
        new JdeField("KMUPMC", "KMUPMC", JdeDataType.Numeric),
        new JdeField("KMFNAM", "KMFNAM", JdeDataType.String, 20),
        new JdeField("KMDEV", "KMDEV", JdeDataType.String, 20),
        new JdeField("KMTDEN", "KMTDEN", JdeDataType.String, 22),
        new JdeField("KMLBN", "KMLBN", JdeDataType.String, 30),
        new JdeField("KMRECL", "KMRECL", JdeDataType.Numeric),
        new JdeField("KMBLK", "KMBLK", JdeDataType.Numeric),
        new JdeField("KMNVOL", "KMNVOL", JdeDataType.String, 12),
        new JdeField("KMNOWN", "KMNOWN", JdeDataType.String, 28),
        new JdeField("KMBACS", "KMBACS", JdeDataType.Numeric),
        new JdeField("KMPTPE", "KMPTPE", JdeDataType.Numeric),
        new JdeField("KMAA", "KMAA", JdeDataType.Numeric),
        new JdeField("KMBPDJ", "KMBPDJ", JdeDataType.Numeric),
        new JdeField("KMBXDJ", "KMBXDJ", JdeDataType.Numeric),
        new JdeField("KMBARP", "KMBARP", JdeDataType.String, 2),
        new JdeField("KMGFL3", "KMGFL3", JdeDataType.String, 2),
        new JdeField("KMGFL4", "KMGFL4", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0457_0", "Primary Key on KMFILE, KMMID", new[] { "KMFILE", "KMMID" }, isUnique: true, isPrimaryKey: true)
    };
}
