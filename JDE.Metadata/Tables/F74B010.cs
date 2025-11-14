using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74B010 - .
/// </summary>
public class F74B010 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCCO.
        /// </summary>
        public const string CCCO = "CCCO";

        /// <summary>
        /// CCB74DR.
        /// </summary>
        public const string CCB74DR = "CCB74DR";

        /// <summary>
        /// CCB74BFT.
        /// </summary>
        public const string CCB74BFT = "CCB74BFT";

        /// <summary>
        /// CCB74FN.
        /// </summary>
        public const string CCB74FN = "CCB74FN";

        /// <summary>
        /// CCB74FD.
        /// </summary>
        public const string CCB74FD = "CCB74FD";

        /// <summary>
        /// CCB74COM.
        /// </summary>
        public const string CCB74COM = "CCB74COM";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCPID.
        /// </summary>
        public const string CCPID = "CCPID";

        /// <summary>
        /// CCUPMJ.
        /// </summary>
        public const string CCUPMJ = "CCUPMJ";

        /// <summary>
        /// CCUPMT.
        /// </summary>
        public const string CCUPMT = "CCUPMT";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F74B010";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCCO", "CCCO", JdeDataType.String, 10, true, true),
        new JdeField("CCB74DR", "CCB74DR", JdeDataType.String, 28),
        new JdeField("CCB74BFT", "CCB74BFT", JdeDataType.String, 20),
        new JdeField("CCB74FN", "CCB74FN", JdeDataType.String, 200),
        new JdeField("CCB74FD", "CCB74FD", JdeDataType.String, 200),
        new JdeField("CCB74COM", "CCB74COM", JdeDataType.String, 2000),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCPID", "CCPID", JdeDataType.String, 20),
        new JdeField("CCUPMJ", "CCUPMJ", JdeDataType.Numeric),
        new JdeField("CCUPMT", "CCUPMT", JdeDataType.Numeric),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74B010_0", "Primary Key on CCCO", new[] { "CCCO" }, isUnique: true, isPrimaryKey: true)
    };
}
