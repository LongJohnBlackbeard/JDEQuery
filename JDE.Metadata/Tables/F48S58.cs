using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F48S58 - .
/// </summary>
public class F48S58 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// F7FBDUBE.
        /// </summary>
        public const string F7FBDUBE = "F7FBDUBE";

        /// <summary>
        /// F7INTY.
        /// </summary>
        public const string F7INTY = "F7INTY";

        /// <summary>
        /// F7VER.
        /// </summary>
        public const string F7VER = "F7VER";

        /// <summary>
        /// F7WFDS.
        /// </summary>
        public const string F7WFDS = "F7WFDS";

        /// <summary>
        /// F7INVF.
        /// </summary>
        public const string F7INVF = "F7INVF";

        /// <summary>
        /// F7DL01.
        /// </summary>
        public const string F7DL01 = "F7DL01";

        /// <summary>
        /// F7TYKY.
        /// </summary>
        public const string F7TYKY = "F7TYKY";

        /// <summary>
        /// F7TKEY.
        /// </summary>
        public const string F7TKEY = "F7TKEY";

        /// <summary>
        /// F7DCTO.
        /// </summary>
        public const string F7DCTO = "F7DCTO";

        /// <summary>
        /// F7KCOO.
        /// </summary>
        public const string F7KCOO = "F7KCOO";

        /// <summary>
        /// F7USER.
        /// </summary>
        public const string F7USER = "F7USER";

        /// <summary>
        /// F7JOBN.
        /// </summary>
        public const string F7JOBN = "F7JOBN";

        /// <summary>
        /// F7PID.
        /// </summary>
        public const string F7PID = "F7PID";

        /// <summary>
        /// F7UPMJ.
        /// </summary>
        public const string F7UPMJ = "F7UPMJ";

        /// <summary>
        /// F7UPMT.
        /// </summary>
        public const string F7UPMT = "F7UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F48S58";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("F7FBDUBE", "F7FBDUBE", JdeDataType.String, 20, true, true),
        new JdeField("F7INTY", "F7INTY", JdeDataType.String, 2, true, true),
        new JdeField("F7VER", "F7VER", JdeDataType.String, 20, true, true),
        new JdeField("F7WFDS", "F7WFDS", JdeDataType.String, 2),
        new JdeField("F7INVF", "F7INVF", JdeDataType.String, 20, true, true),
        new JdeField("F7DL01", "F7DL01", JdeDataType.String, 60),
        new JdeField("F7TYKY", "F7TYKY", JdeDataType.String, 2, true, true),
        new JdeField("F7TKEY", "F7TKEY", JdeDataType.String, 24, true, true),
        new JdeField("F7DCTO", "F7DCTO", JdeDataType.String, 4, true, true),
        new JdeField("F7KCOO", "F7KCOO", JdeDataType.String, 10, true, true),
        new JdeField("F7USER", "F7USER", JdeDataType.String, 20),
        new JdeField("F7JOBN", "F7JOBN", JdeDataType.String, 20),
        new JdeField("F7PID", "F7PID", JdeDataType.String, 20),
        new JdeField("F7UPMJ", "F7UPMJ", JdeDataType.Numeric),
        new JdeField("F7UPMT", "F7UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F48S58_0", "Primary Key on F7FBDUBE, F7INTY, F7VER, F7INVF, F7TYKY, F7TKEY, F7DCTO, F7KCOO", new[] { "F7FBDUBE", "F7INTY", "F7VER", "F7INVF", "F7TYKY", "F7TKEY", "F7DCTO", "F7KCOO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F48S58_3", "Unique Index on F7INTY, F7INVF, F7TYKY, F7TKEY, F7DCTO, F7KCOO", new[] { "F7INTY", "F7INVF", "F7TYKY", "F7TKEY", "F7DCTO", "F7KCOO" }, isUnique: true),
        new JdeIndex("F48S58_4", "Index on F7INVF, F7INTY, F7DL01", new[] { "F7INVF", "F7INTY", "F7DL01" }),
        new JdeIndex("F48S58_5", "Index on F7INVF", new[] { "F7INVF" })
    };
}
