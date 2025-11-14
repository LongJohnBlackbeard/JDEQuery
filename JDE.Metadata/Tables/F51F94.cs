using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F94 - .
/// </summary>
public class F51F94 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QUCCT.
        /// </summary>
        public const string QUCCT = "QUCCT";

        /// <summary>
        /// QU51FEFD.
        /// </summary>
        public const string QU51FEFD = "QU51FEFD";

        /// <summary>
        /// QU51FETD.
        /// </summary>
        public const string QU51FETD = "QU51FETD";

        /// <summary>
        /// QUENTJ.
        /// </summary>
        public const string QUENTJ = "QUENTJ";

        /// <summary>
        /// QUTENT.
        /// </summary>
        public const string QUTENT = "QUTENT";

        /// <summary>
        /// QUUSER.
        /// </summary>
        public const string QUUSER = "QUUSER";

        /// <summary>
        /// QUUPMJ.
        /// </summary>
        public const string QUUPMJ = "QUUPMJ";

        /// <summary>
        /// QUUPMT.
        /// </summary>
        public const string QUUPMT = "QUUPMT";

        /// <summary>
        /// QUJOBN.
        /// </summary>
        public const string QUJOBN = "QUJOBN";

        /// <summary>
        /// QUPID.
        /// </summary>
        public const string QUPID = "QUPID";

        /// <summary>
        /// QUMKEY.
        /// </summary>
        public const string QUMKEY = "QUMKEY";

        /// <summary>
        /// QUTORG.
        /// </summary>
        public const string QUTORG = "QUTORG";
    }

    /// <inheritdoc />
    public override string TableName => "F51F94";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QUCCT", "QUCCT", JdeDataType.String, 2, true, true),
        new JdeField("QU51FEFD", "QU51FEFD", JdeDataType.Numeric, null, true, true),
        new JdeField("QU51FETD", "QU51FETD", JdeDataType.Numeric),
        new JdeField("QUENTJ", "QUENTJ", JdeDataType.Numeric),
        new JdeField("QUTENT", "QUTENT", JdeDataType.Numeric),
        new JdeField("QUUSER", "QUUSER", JdeDataType.String, 20),
        new JdeField("QUUPMJ", "QUUPMJ", JdeDataType.Numeric),
        new JdeField("QUUPMT", "QUUPMT", JdeDataType.Numeric),
        new JdeField("QUJOBN", "QUJOBN", JdeDataType.String, 20),
        new JdeField("QUPID", "QUPID", JdeDataType.String, 20),
        new JdeField("QUMKEY", "QUMKEY", JdeDataType.String, 30),
        new JdeField("QUTORG", "QUTORG", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F94_0", "Primary Key on QUCCT, QU51FEFD", new[] { "QUCCT", "QU51FEFD" }, isUnique: true, isPrimaryKey: true)
    };
}
