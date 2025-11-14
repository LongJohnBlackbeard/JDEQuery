using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F34A60 - .
/// </summary>
public class F34A60 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// OBITM.
        /// </summary>
        public const string OBITM = "OBITM";

        /// <summary>
        /// OBMCU.
        /// </summary>
        public const string OBMCU = "OBMCU";

        /// <summary>
        /// OBMMCU.
        /// </summary>
        public const string OBMMCU = "OBMMCU";

        /// <summary>
        /// OBAN8.
        /// </summary>
        public const string OBAN8 = "OBAN8";

        /// <summary>
        /// OBRSDJ.
        /// </summary>
        public const string OBRSDJ = "OBRSDJ";

        /// <summary>
        /// OBTRQT.
        /// </summary>
        public const string OBTRQT = "OBTRQT";

        /// <summary>
        /// OBPPDJ.
        /// </summary>
        public const string OBPPDJ = "OBPPDJ";

        /// <summary>
        /// OBPS01.
        /// </summary>
        public const string OBPS01 = "OBPS01";

        /// <summary>
        /// OBUNCD.
        /// </summary>
        public const string OBUNCD = "OBUNCD";

        /// <summary>
        /// OBEV01.
        /// </summary>
        public const string OBEV01 = "OBEV01";

        /// <summary>
        /// OBDOCO.
        /// </summary>
        public const string OBDOCO = "OBDOCO";

        /// <summary>
        /// OBDCTO.
        /// </summary>
        public const string OBDCTO = "OBDCTO";

        /// <summary>
        /// OBKCOO.
        /// </summary>
        public const string OBKCOO = "OBKCOO";

        /// <summary>
        /// OBSFXO.
        /// </summary>
        public const string OBSFXO = "OBSFXO";

        /// <summary>
        /// OBLNID.
        /// </summary>
        public const string OBLNID = "OBLNID";
    }

    /// <inheritdoc />
    public override string TableName => "F34A60";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("OBITM", "OBITM", JdeDataType.Numeric, null, true, true),
        new JdeField("OBMCU", "OBMCU", JdeDataType.String, 24),
        new JdeField("OBMMCU", "OBMMCU", JdeDataType.String, 24),
        new JdeField("OBAN8", "OBAN8", JdeDataType.Numeric),
        new JdeField("OBRSDJ", "OBRSDJ", JdeDataType.Numeric),
        new JdeField("OBTRQT", "OBTRQT", JdeDataType.Numeric),
        new JdeField("OBPPDJ", "OBPPDJ", JdeDataType.Numeric),
        new JdeField("OBPS01", "OBPS01", JdeDataType.String, 2),
        new JdeField("OBUNCD", "OBUNCD", JdeDataType.String, 2),
        new JdeField("OBEV01", "OBEV01", JdeDataType.String, 2),
        new JdeField("OBDOCO", "OBDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("OBDCTO", "OBDCTO", JdeDataType.String, 4, true, true),
        new JdeField("OBKCOO", "OBKCOO", JdeDataType.String, 10, true, true),
        new JdeField("OBSFXO", "OBSFXO", JdeDataType.String, 6, true, true),
        new JdeField("OBLNID", "OBLNID", JdeDataType.Numeric, null, true, true)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F34A60_0", "Primary Key on OBDOCO, OBDCTO, OBKCOO, OBSFXO, OBLNID, OBITM", new[] { "OBDOCO", "OBDCTO", "OBKCOO", "OBSFXO", "OBLNID", "OBITM" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F34A60_2", "Index on OBEV01, OBPS01", new[] { "OBEV01", "OBPS01" })
    };
}
