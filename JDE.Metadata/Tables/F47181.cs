using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F47181 - .
/// </summary>
public class F47181 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// EHEDOC.
        /// </summary>
        public const string EHEDOC = "EHEDOC";

        /// <summary>
        /// EHEDCT.
        /// </summary>
        public const string EHEDCT = "EHEDCT";

        /// <summary>
        /// EHEKCO.
        /// </summary>
        public const string EHEKCO = "EHEKCO";

        /// <summary>
        /// EHAN8.
        /// </summary>
        public const string EHAN8 = "EHAN8";

        /// <summary>
        /// EHSHAN.
        /// </summary>
        public const string EHSHAN = "EHSHAN";

        /// <summary>
        /// EHTRDJ.
        /// </summary>
        public const string EHTRDJ = "EHTRDJ";

        /// <summary>
        /// EHTPUR.
        /// </summary>
        public const string EHTPUR = "EHTPUR";

        /// <summary>
        /// EHURCD.
        /// </summary>
        public const string EHURCD = "EHURCD";

        /// <summary>
        /// EHURDT.
        /// </summary>
        public const string EHURDT = "EHURDT";

        /// <summary>
        /// EHURAT.
        /// </summary>
        public const string EHURAT = "EHURAT";

        /// <summary>
        /// EHURAB.
        /// </summary>
        public const string EHURAB = "EHURAB";

        /// <summary>
        /// EHURRF.
        /// </summary>
        public const string EHURRF = "EHURRF";

        /// <summary>
        /// EHEDST.
        /// </summary>
        public const string EHEDST = "EHEDST";

        /// <summary>
        /// EHEDFT.
        /// </summary>
        public const string EHEDFT = "EHEDFT";

        /// <summary>
        /// EHEDDT.
        /// </summary>
        public const string EHEDDT = "EHEDDT";

        /// <summary>
        /// EHEDER.
        /// </summary>
        public const string EHEDER = "EHEDER";

        /// <summary>
        /// EHEDDL.
        /// </summary>
        public const string EHEDDL = "EHEDDL";

        /// <summary>
        /// EHEDBT.
        /// </summary>
        public const string EHEDBT = "EHEDBT";

        /// <summary>
        /// EHPNID.
        /// </summary>
        public const string EHPNID = "EHPNID";

        /// <summary>
        /// EHEDSP.
        /// </summary>
        public const string EHEDSP = "EHEDSP";

        /// <summary>
        /// EHEDTY.
        /// </summary>
        public const string EHEDTY = "EHEDTY";

        /// <summary>
        /// EHEDSQ.
        /// </summary>
        public const string EHEDSQ = "EHEDSQ";

        /// <summary>
        /// EHTORG.
        /// </summary>
        public const string EHTORG = "EHTORG";

        /// <summary>
        /// EHUSER.
        /// </summary>
        public const string EHUSER = "EHUSER";

        /// <summary>
        /// EHPID.
        /// </summary>
        public const string EHPID = "EHPID";

        /// <summary>
        /// EHJOBN.
        /// </summary>
        public const string EHJOBN = "EHJOBN";

        /// <summary>
        /// EHUPMJ.
        /// </summary>
        public const string EHUPMJ = "EHUPMJ";

        /// <summary>
        /// EHTDAY.
        /// </summary>
        public const string EHTDAY = "EHTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F47181";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("EHEDOC", "EHEDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("EHEDCT", "EHEDCT", JdeDataType.String, 4, true, true),
        new JdeField("EHEKCO", "EHEKCO", JdeDataType.String, 10, true, true),
        new JdeField("EHAN8", "EHAN8", JdeDataType.Numeric),
        new JdeField("EHSHAN", "EHSHAN", JdeDataType.Numeric),
        new JdeField("EHTRDJ", "EHTRDJ", JdeDataType.Numeric),
        new JdeField("EHTPUR", "EHTPUR", JdeDataType.String, 4),
        new JdeField("EHURCD", "EHURCD", JdeDataType.String, 4),
        new JdeField("EHURDT", "EHURDT", JdeDataType.Numeric),
        new JdeField("EHURAT", "EHURAT", JdeDataType.Numeric),
        new JdeField("EHURAB", "EHURAB", JdeDataType.Numeric),
        new JdeField("EHURRF", "EHURRF", JdeDataType.String, 30),
        new JdeField("EHEDST", "EHEDST", JdeDataType.String, 12),
        new JdeField("EHEDFT", "EHEDFT", JdeDataType.String, 20),
        new JdeField("EHEDDT", "EHEDDT", JdeDataType.Numeric),
        new JdeField("EHEDER", "EHEDER", JdeDataType.String, 2),
        new JdeField("EHEDDL", "EHEDDL", JdeDataType.Numeric),
        new JdeField("EHEDBT", "EHEDBT", JdeDataType.String, 30),
        new JdeField("EHPNID", "EHPNID", JdeDataType.String, 30),
        new JdeField("EHEDSP", "EHEDSP", JdeDataType.String, 2),
        new JdeField("EHEDTY", "EHEDTY", JdeDataType.String, 2),
        new JdeField("EHEDSQ", "EHEDSQ", JdeDataType.Numeric),
        new JdeField("EHTORG", "EHTORG", JdeDataType.String, 20),
        new JdeField("EHUSER", "EHUSER", JdeDataType.String, 20),
        new JdeField("EHPID", "EHPID", JdeDataType.String, 20),
        new JdeField("EHJOBN", "EHJOBN", JdeDataType.String, 20),
        new JdeField("EHUPMJ", "EHUPMJ", JdeDataType.Numeric),
        new JdeField("EHTDAY", "EHTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F47181_0", "Primary Key on EHEDOC, EHEDCT, EHEKCO", new[] { "EHEDOC", "EHEDCT", "EHEKCO" }, isUnique: true, isPrimaryKey: true)
    };
}
