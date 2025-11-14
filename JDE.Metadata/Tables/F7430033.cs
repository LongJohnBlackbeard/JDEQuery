using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430033 - .
/// </summary>
public class F7430033 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PIKCO.
        /// </summary>
        public const string PIKCO = "PIKCO";

        /// <summary>
        /// PIDCT.
        /// </summary>
        public const string PIDCT = "PIDCT";

        /// <summary>
        /// PIDOC.
        /// </summary>
        public const string PIDOC = "PIDOC";

        /// <summary>
        /// PISEQ.
        /// </summary>
        public const string PISEQ = "PISEQ";

        /// <summary>
        /// PIRMK.
        /// </summary>
        public const string PIRMK = "PIRMK";

        /// <summary>
        /// PIMCU.
        /// </summary>
        public const string PIMCU = "PIMCU";

        /// <summary>
        /// PITXA1.
        /// </summary>
        public const string PITXA1 = "PITXA1";

        /// <summary>
        /// PIEXR1.
        /// </summary>
        public const string PIEXR1 = "PIEXR1";

        /// <summary>
        /// PICRCD.
        /// </summary>
        public const string PICRCD = "PICRCD";

        /// <summary>
        /// PIATXA.
        /// </summary>
        public const string PIATXA = "PIATXA";

        /// <summary>
        /// PIATXN.
        /// </summary>
        public const string PIATXN = "PIATXN";

        /// <summary>
        /// PIADSC.
        /// </summary>
        public const string PIADSC = "PIADSC";

        /// <summary>
        /// PISTAM.
        /// </summary>
        public const string PISTAM = "PISTAM";

        /// <summary>
        /// PIAG.
        /// </summary>
        public const string PIAG = "PIAG";
    }

    /// <inheritdoc />
    public override string TableName => "F7430033";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PIKCO", "PIKCO", JdeDataType.String, 10, true, true),
        new JdeField("PIDCT", "PIDCT", JdeDataType.String, 4, true, true),
        new JdeField("PIDOC", "PIDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("PISEQ", "PISEQ", JdeDataType.Numeric, null, true, true),
        new JdeField("PIRMK", "PIRMK", JdeDataType.String, 60),
        new JdeField("PIMCU", "PIMCU", JdeDataType.String, 24),
        new JdeField("PITXA1", "PITXA1", JdeDataType.String, 20),
        new JdeField("PIEXR1", "PIEXR1", JdeDataType.String, 4),
        new JdeField("PICRCD", "PICRCD", JdeDataType.String, 6),
        new JdeField("PIATXA", "PIATXA", JdeDataType.Numeric),
        new JdeField("PIATXN", "PIATXN", JdeDataType.Numeric),
        new JdeField("PIADSC", "PIADSC", JdeDataType.Numeric),
        new JdeField("PISTAM", "PISTAM", JdeDataType.Numeric),
        new JdeField("PIAG", "PIAG", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430033_0", "Primary Key on PIKCO, PIDCT, PIDOC, PISEQ", new[] { "PIKCO", "PIDCT", "PIDOC", "PISEQ" }, isUnique: true, isPrimaryKey: true)
    };
}
