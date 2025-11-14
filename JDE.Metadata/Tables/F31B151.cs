using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31B151 - .
/// </summary>
public class F31B151 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DCDCCO.
        /// </summary>
        public const string DCDCCO = "DCDCCO";

        /// <summary>
        /// DCMCU.
        /// </summary>
        public const string DCMCU = "DCMCU";

        /// <summary>
        /// DCDPVA.
        /// </summary>
        public const string DCDPVA = "DCDPVA";

        /// <summary>
        /// DCDPVO.
        /// </summary>
        public const string DCDPVO = "DCDPVO";

        /// <summary>
        /// DCWTKID.
        /// </summary>
        public const string DCWTKID = "DCWTKID";

        /// <summary>
        /// DCDPVN.
        /// </summary>
        public const string DCDPVN = "DCDPVN";

        /// <summary>
        /// DCDVPI.
        /// </summary>
        public const string DCDVPI = "DCDVPI";

        /// <summary>
        /// DCDPVA1.
        /// </summary>
        public const string DCDPVA1 = "DCDPVA1";

        /// <summary>
        /// DCDPVA2.
        /// </summary>
        public const string DCDPVA2 = "DCDPVA2";

        /// <summary>
        /// DCDPVA3.
        /// </summary>
        public const string DCDPVA3 = "DCDPVA3";

        /// <summary>
        /// DCDPVAM.
        /// </summary>
        public const string DCDPVAM = "DCDPVAM";
    }

    /// <inheritdoc />
    public override string TableName => "F31B151";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DCDCCO", "DCDCCO", JdeDataType.String, 16, true, true),
        new JdeField("DCMCU", "DCMCU", JdeDataType.String, 24, true, true),
        new JdeField("DCDPVA", "DCDPVA", JdeDataType.Numeric, null, true, true),
        new JdeField("DCDPVO", "DCDPVO", JdeDataType.Numeric),
        new JdeField("DCWTKID", "DCWTKID", JdeDataType.Numeric),
        new JdeField("DCDPVN", "DCDPVN", JdeDataType.Numeric),
        new JdeField("DCDVPI", "DCDVPI", JdeDataType.Numeric),
        new JdeField("DCDPVA1", "DCDPVA1", JdeDataType.Numeric),
        new JdeField("DCDPVA2", "DCDPVA2", JdeDataType.Numeric),
        new JdeField("DCDPVA3", "DCDPVA3", JdeDataType.Numeric),
        new JdeField("DCDPVAM", "DCDPVAM", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31B151_0", "Primary Key on DCDCCO, DCMCU, DCDPVA", new[] { "DCDCCO", "DCMCU", "DCDPVA" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31B151_2", "Index on DCDCCO, DCMCU", new[] { "DCDCCO", "DCMCU" }),
        new JdeIndex("F31B151_3", "Index on DCDCCO, DCMCU, SYS_NC00012$", new[] { "DCDCCO", "DCMCU", "SYS_NC00012$" }),
        new JdeIndex("F31B151_4", "Index on DCDCCO, DCMCU, DCDPVO", new[] { "DCDCCO", "DCMCU", "DCDPVO" }),
        new JdeIndex("F31B151_5", "Index on DCDCCO, DCMCU, SYS_NC00013$", new[] { "DCDCCO", "DCMCU", "SYS_NC00013$" })
    };
}
