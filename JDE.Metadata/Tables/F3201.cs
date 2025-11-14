using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F3201 - .
/// </summary>
public class F3201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CMCFGID.
        /// </summary>
        public const string CMCFGID = "CMCFGID";

        /// <summary>
        /// CMKCOO.
        /// </summary>
        public const string CMKCOO = "CMKCOO";

        /// <summary>
        /// CMDOCO.
        /// </summary>
        public const string CMDOCO = "CMDOCO";

        /// <summary>
        /// CMDCTO.
        /// </summary>
        public const string CMDCTO = "CMDCTO";

        /// <summary>
        /// CMSFXO.
        /// </summary>
        public const string CMSFXO = "CMSFXO";

        /// <summary>
        /// CMLNID.
        /// </summary>
        public const string CMLNID = "CMLNID";

        /// <summary>
        /// CMCFGCID.
        /// </summary>
        public const string CMCFGCID = "CMCFGCID";

        /// <summary>
        /// CMSY.
        /// </summary>
        public const string CMSY = "CMSY";

        /// <summary>
        /// CMAN8.
        /// </summary>
        public const string CMAN8 = "CMAN8";

        /// <summary>
        /// CMSHAN.
        /// </summary>
        public const string CMSHAN = "CMSHAN";

        /// <summary>
        /// CMEMCU.
        /// </summary>
        public const string CMEMCU = "CMEMCU";

        /// <summary>
        /// CMCO.
        /// </summary>
        public const string CMCO = "CMCO";

        /// <summary>
        /// CMCRRM.
        /// </summary>
        public const string CMCRRM = "CMCRRM";

        /// <summary>
        /// CMCRCD.
        /// </summary>
        public const string CMCRCD = "CMCRCD";

        /// <summary>
        /// CMCRDC.
        /// </summary>
        public const string CMCRDC = "CMCRDC";

        /// <summary>
        /// CMURCD.
        /// </summary>
        public const string CMURCD = "CMURCD";

        /// <summary>
        /// CMURDT.
        /// </summary>
        public const string CMURDT = "CMURDT";

        /// <summary>
        /// CMURAT.
        /// </summary>
        public const string CMURAT = "CMURAT";

        /// <summary>
        /// CMURAB.
        /// </summary>
        public const string CMURAB = "CMURAB";

        /// <summary>
        /// CMURRF.
        /// </summary>
        public const string CMURRF = "CMURRF";

        /// <summary>
        /// CMUSER.
        /// </summary>
        public const string CMUSER = "CMUSER";

        /// <summary>
        /// CMPID.
        /// </summary>
        public const string CMPID = "CMPID";

        /// <summary>
        /// CMJOBN.
        /// </summary>
        public const string CMJOBN = "CMJOBN";

        /// <summary>
        /// CMUPMJ.
        /// </summary>
        public const string CMUPMJ = "CMUPMJ";

        /// <summary>
        /// CMTDAY.
        /// </summary>
        public const string CMTDAY = "CMTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F3201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CMCFGID", "CMCFGID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMKCOO", "CMKCOO", JdeDataType.String, 10, true, true),
        new JdeField("CMDOCO", "CMDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("CMDCTO", "CMDCTO", JdeDataType.String, 4, true, true),
        new JdeField("CMSFXO", "CMSFXO", JdeDataType.String, 6, true, true),
        new JdeField("CMLNID", "CMLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMCFGCID", "CMCFGCID", JdeDataType.Numeric, null, true, true),
        new JdeField("CMSY", "CMSY", JdeDataType.String, 8, true, true),
        new JdeField("CMAN8", "CMAN8", JdeDataType.Numeric),
        new JdeField("CMSHAN", "CMSHAN", JdeDataType.Numeric),
        new JdeField("CMEMCU", "CMEMCU", JdeDataType.String, 24),
        new JdeField("CMCO", "CMCO", JdeDataType.String, 10),
        new JdeField("CMCRRM", "CMCRRM", JdeDataType.String, 2),
        new JdeField("CMCRCD", "CMCRCD", JdeDataType.String, 6),
        new JdeField("CMCRDC", "CMCRDC", JdeDataType.String, 6),
        new JdeField("CMURCD", "CMURCD", JdeDataType.String, 4),
        new JdeField("CMURDT", "CMURDT", JdeDataType.Numeric),
        new JdeField("CMURAT", "CMURAT", JdeDataType.Numeric),
        new JdeField("CMURAB", "CMURAB", JdeDataType.Numeric),
        new JdeField("CMURRF", "CMURRF", JdeDataType.String, 30),
        new JdeField("CMUSER", "CMUSER", JdeDataType.String, 20),
        new JdeField("CMPID", "CMPID", JdeDataType.String, 20),
        new JdeField("CMJOBN", "CMJOBN", JdeDataType.String, 20),
        new JdeField("CMUPMJ", "CMUPMJ", JdeDataType.Numeric),
        new JdeField("CMTDAY", "CMTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F3201_0", "Primary Key on CMCFGID, CMCFGCID, CMSY, CMKCOO, CMDOCO, CMDCTO, CMSFXO, CMLNID", new[] { "CMCFGID", "CMCFGCID", "CMSY", "CMKCOO", "CMDOCO", "CMDCTO", "CMSFXO", "CMLNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F3201_2", "Index on CMSY, CMKCOO, CMDOCO, CMDCTO, CMSFXO, CMLNID", new[] { "CMSY", "CMKCOO", "CMDOCO", "CMDCTO", "CMSFXO", "CMLNID" }),
        new JdeIndex("F3201_4", "Index on CMCFGID, CMSY, CMCFGCID", new[] { "CMCFGID", "CMSY", "CMCFGCID" })
    };
}
