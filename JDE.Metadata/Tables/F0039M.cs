using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F0039M - .
/// </summary>
public class F0039M : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// GHOBNM.
        /// </summary>
        public const string GHOBNM = "GHOBNM";

        /// <summary>
        /// GHITM.
        /// </summary>
        public const string GHITM = "GHITM";

        /// <summary>
        /// GHMCU.
        /// </summary>
        public const string GHMCU = "GHMCU";

        /// <summary>
        /// GHAN8.
        /// </summary>
        public const string GHAN8 = "GHAN8";

        /// <summary>
        /// GHCO.
        /// </summary>
        public const string GHCO = "GHCO";

        /// <summary>
        /// GHLNGP.
        /// </summary>
        public const string GHLNGP = "GHLNGP";

        /// <summary>
        /// GHGN01.
        /// </summary>
        public const string GHGN01 = "GHGN01";

        /// <summary>
        /// GHURCD.
        /// </summary>
        public const string GHURCD = "GHURCD";

        /// <summary>
        /// GHURDT.
        /// </summary>
        public const string GHURDT = "GHURDT";

        /// <summary>
        /// GHURAT.
        /// </summary>
        public const string GHURAT = "GHURAT";

        /// <summary>
        /// GHURAB.
        /// </summary>
        public const string GHURAB = "GHURAB";

        /// <summary>
        /// GHURRF.
        /// </summary>
        public const string GHURRF = "GHURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F0039M";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("GHOBNM", "GHOBNM", JdeDataType.String, 20, true, true),
        new JdeField("GHITM", "GHITM", JdeDataType.Numeric, null, true, true),
        new JdeField("GHMCU", "GHMCU", JdeDataType.String, 24, true, true),
        new JdeField("GHAN8", "GHAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("GHCO", "GHCO", JdeDataType.String, 10, true, true),
        new JdeField("GHLNGP", "GHLNGP", JdeDataType.String, 4, true, true),
        new JdeField("GHGN01", "GHGN01", JdeDataType.String, 20, true, true),
        new JdeField("GHURCD", "GHURCD", JdeDataType.String, 4),
        new JdeField("GHURDT", "GHURDT", JdeDataType.Numeric),
        new JdeField("GHURAT", "GHURAT", JdeDataType.Numeric),
        new JdeField("GHURAB", "GHURAB", JdeDataType.Numeric),
        new JdeField("GHURRF", "GHURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F0039M_0", "Primary Key on GHOBNM, GHITM, GHMCU, GHAN8, GHCO, GHLNGP, GHGN01", new[] { "GHOBNM", "GHITM", "GHMCU", "GHAN8", "GHCO", "GHLNGP", "GHGN01" }, isUnique: true, isPrimaryKey: true)
    };
}
