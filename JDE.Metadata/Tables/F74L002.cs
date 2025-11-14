using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F74L002 - .
/// </summary>
public class F74L002 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// UUK74LECO.
        /// </summary>
        public const string UUK74LECO = "UUK74LECO";

        /// <summary>
        /// UUK74LEDT.
        /// </summary>
        public const string UUK74LEDT = "UUK74LEDT";

        /// <summary>
        /// UUK74ISPL.
        /// </summary>
        public const string UUK74ISPL = "UUK74ISPL";

        /// <summary>
        /// UUK74LENU.
        /// </summary>
        public const string UUK74LENU = "UUK74LENU";

        /// <summary>
        /// UUL74ACPT.
        /// </summary>
        public const string UUL74ACPT = "UUL74ACPT";

        /// <summary>
        /// UUL74UUR.
        /// </summary>
        public const string UUL74UUR = "UUL74UUR";

        /// <summary>
        /// UUL74DTE.
        /// </summary>
        public const string UUL74DTE = "UUL74DTE";

        /// <summary>
        /// UUL74DTAC.
        /// </summary>
        public const string UUL74DTAC = "UUL74DTAC";

        /// <summary>
        /// UUTORG.
        /// </summary>
        public const string UUTORG = "UUTORG";

        /// <summary>
        /// UUUSER.
        /// </summary>
        public const string UUUSER = "UUUSER";

        /// <summary>
        /// UUPID.
        /// </summary>
        public const string UUPID = "UUPID";

        /// <summary>
        /// UUJOBN.
        /// </summary>
        public const string UUJOBN = "UUJOBN";

        /// <summary>
        /// UUUPMJ.
        /// </summary>
        public const string UUUPMJ = "UUUPMJ";

        /// <summary>
        /// UUUPMT.
        /// </summary>
        public const string UUUPMT = "UUUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F74L002";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("UUK74LECO", "UUK74LECO", JdeDataType.String, 10, true, true),
        new JdeField("UUK74LEDT", "UUK74LEDT", JdeDataType.String, 10, true, true),
        new JdeField("UUK74ISPL", "UUK74ISPL", JdeDataType.String, 30, true, true),
        new JdeField("UUK74LENU", "UUK74LENU", JdeDataType.Numeric, null, true, true),
        new JdeField("UUL74ACPT", "UUL74ACPT", JdeDataType.String, 2),
        new JdeField("UUL74UUR", "UUL74UUR", JdeDataType.String, 4),
        new JdeField("UUL74DTE", "UUL74DTE", JdeDataType.Numeric),
        new JdeField("UUL74DTAC", "UUL74DTAC", JdeDataType.Numeric),
        new JdeField("UUTORG", "UUTORG", JdeDataType.String, 20),
        new JdeField("UUUSER", "UUUSER", JdeDataType.String, 20),
        new JdeField("UUPID", "UUPID", JdeDataType.String, 20),
        new JdeField("UUJOBN", "UUJOBN", JdeDataType.String, 20),
        new JdeField("UUUPMJ", "UUUPMJ", JdeDataType.Numeric),
        new JdeField("UUUPMT", "UUUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F74L002_0", "Primary Key on UUK74LECO, UUK74LEDT, UUK74ISPL, UUK74LENU", new[] { "UUK74LECO", "UUK74LEDT", "UUK74ISPL", "UUK74LENU" }, isUnique: true, isPrimaryKey: true)
    };
}
