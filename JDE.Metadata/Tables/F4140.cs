using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4140 - .
/// </summary>
public class F4140 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PICYNO.
        /// </summary>
        public const string PICYNO = "PICYNO";

        /// <summary>
        /// PIDSC1.
        /// </summary>
        public const string PIDSC1 = "PIDSC1";

        /// <summary>
        /// PICYCS.
        /// </summary>
        public const string PICYCS = "PICYCS";

        /// <summary>
        /// PICSDJ.
        /// </summary>
        public const string PICSDJ = "PICSDJ";

        /// <summary>
        /// PICYIT.
        /// </summary>
        public const string PICYIT = "PICYIT";

        /// <summary>
        /// PICYLO.
        /// </summary>
        public const string PICYLO = "PICYLO";

        /// <summary>
        /// PIUSER.
        /// </summary>
        public const string PIUSER = "PIUSER";

        /// <summary>
        /// PIPID.
        /// </summary>
        public const string PIPID = "PIPID";

        /// <summary>
        /// PIJOBN.
        /// </summary>
        public const string PIJOBN = "PIJOBN";

        /// <summary>
        /// PIUPMJ.
        /// </summary>
        public const string PIUPMJ = "PIUPMJ";

        /// <summary>
        /// PITDAY.
        /// </summary>
        public const string PITDAY = "PITDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4140";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PICYNO", "PICYNO", JdeDataType.Numeric, null, true, true),
        new JdeField("PIDSC1", "PIDSC1", JdeDataType.String, 60),
        new JdeField("PICYCS", "PICYCS", JdeDataType.String, 4),
        new JdeField("PICSDJ", "PICSDJ", JdeDataType.Numeric),
        new JdeField("PICYIT", "PICYIT", JdeDataType.Numeric),
        new JdeField("PICYLO", "PICYLO", JdeDataType.Numeric),
        new JdeField("PIUSER", "PIUSER", JdeDataType.String, 20),
        new JdeField("PIPID", "PIPID", JdeDataType.String, 20),
        new JdeField("PIJOBN", "PIJOBN", JdeDataType.String, 20),
        new JdeField("PIUPMJ", "PIUPMJ", JdeDataType.Numeric),
        new JdeField("PITDAY", "PITDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4140_0", "Primary Key on PICYNO", new[] { "PICYNO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4140_2", "Index on PICYCS, PICYNO", new[] { "PICYCS", "PICYNO" })
    };
}
