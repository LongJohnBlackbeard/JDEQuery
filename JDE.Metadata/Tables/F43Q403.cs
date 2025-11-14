using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F43Q403 - .
/// </summary>
public class F43Q403 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RIEVNU.
        /// </summary>
        public const string RIEVNU = "RIEVNU";

        /// <summary>
        /// RIDCTO.
        /// </summary>
        public const string RIDCTO = "RIDCTO";

        /// <summary>
        /// RIKCOO.
        /// </summary>
        public const string RIKCOO = "RIKCOO";

        /// <summary>
        /// RIAN8.
        /// </summary>
        public const string RIAN8 = "RIAN8";

        /// <summary>
        /// RIOSEQ.
        /// </summary>
        public const string RIOSEQ = "RIOSEQ";

        /// <summary>
        /// RIRSNT.
        /// </summary>
        public const string RIRSNT = "RIRSNT";

        /// <summary>
        /// RIDCLR.
        /// </summary>
        public const string RIDCLR = "RIDCLR";

        /// <summary>
        /// RIRUTE.
        /// </summary>
        public const string RIRUTE = "RIRUTE";

        /// <summary>
        /// RIURCD.
        /// </summary>
        public const string RIURCD = "RIURCD";

        /// <summary>
        /// RIURDT.
        /// </summary>
        public const string RIURDT = "RIURDT";

        /// <summary>
        /// RIURAT.
        /// </summary>
        public const string RIURAT = "RIURAT";

        /// <summary>
        /// RIURAB.
        /// </summary>
        public const string RIURAB = "RIURAB";

        /// <summary>
        /// RIURRF.
        /// </summary>
        public const string RIURRF = "RIURRF";

        /// <summary>
        /// RITORG.
        /// </summary>
        public const string RITORG = "RITORG";

        /// <summary>
        /// RIUSER.
        /// </summary>
        public const string RIUSER = "RIUSER";

        /// <summary>
        /// RIPID.
        /// </summary>
        public const string RIPID = "RIPID";

        /// <summary>
        /// RIJOBN.
        /// </summary>
        public const string RIJOBN = "RIJOBN";

        /// <summary>
        /// RIUPMJ.
        /// </summary>
        public const string RIUPMJ = "RIUPMJ";

        /// <summary>
        /// RITDAY.
        /// </summary>
        public const string RITDAY = "RITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F43Q403";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RIEVNU", "RIEVNU", JdeDataType.Numeric, null, true, true),
        new JdeField("RIDCTO", "RIDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RIKCOO", "RIKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RIAN8", "RIAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("RIOSEQ", "RIOSEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("RIRSNT", "RIRSNT", JdeDataType.String, 4),
        new JdeField("RIDCLR", "RIDCLR", JdeDataType.String, 6),
        new JdeField("RIRUTE", "RIRUTE", JdeDataType.String, 2),
        new JdeField("RIURCD", "RIURCD", JdeDataType.String, 4),
        new JdeField("RIURDT", "RIURDT", JdeDataType.Numeric),
        new JdeField("RIURAT", "RIURAT", JdeDataType.Numeric),
        new JdeField("RIURAB", "RIURAB", JdeDataType.Numeric),
        new JdeField("RIURRF", "RIURRF", JdeDataType.String, 30),
        new JdeField("RITORG", "RITORG", JdeDataType.String, 20),
        new JdeField("RIUSER", "RIUSER", JdeDataType.String, 20),
        new JdeField("RIPID", "RIPID", JdeDataType.String, 20),
        new JdeField("RIJOBN", "RIJOBN", JdeDataType.String, 20),
        new JdeField("RIUPMJ", "RIUPMJ", JdeDataType.Numeric),
        new JdeField("RITDAY", "RITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F43Q403_0", "Primary Key on RIEVNU, RIDCTO, RIKCOO, RIAN8, RIOSEQ", new[] { "RIEVNU", "RIDCTO", "RIKCOO", "RIAN8", "RIOSEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
