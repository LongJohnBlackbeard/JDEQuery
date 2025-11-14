using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7464108 - .
/// </summary>
public class F7464108 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LOLOTN.
        /// </summary>
        public const string LOLOTN = "LOLOTN";

        /// <summary>
        /// LOITM.
        /// </summary>
        public const string LOITM = "LOITM";

        /// <summary>
        /// LOMCU.
        /// </summary>
        public const string LOMCU = "LOMCU";

        /// <summary>
        /// LOK74CUDE.
        /// </summary>
        public const string LOK74CUDE = "LOK74CUDE";

        /// <summary>
        /// LOK74CUDJ.
        /// </summary>
        public const string LOK74CUDJ = "LOK74CUDJ";

        /// <summary>
        /// LOK74CUCO.
        /// </summary>
        public const string LOK74CUCO = "LOK74CUCO";

        /// <summary>
        /// LOUSER.
        /// </summary>
        public const string LOUSER = "LOUSER";

        /// <summary>
        /// LOPID.
        /// </summary>
        public const string LOPID = "LOPID";

        /// <summary>
        /// LOJOBN.
        /// </summary>
        public const string LOJOBN = "LOJOBN";

        /// <summary>
        /// LOUPMJ.
        /// </summary>
        public const string LOUPMJ = "LOUPMJ";

        /// <summary>
        /// LOUPMT.
        /// </summary>
        public const string LOUPMT = "LOUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F7464108";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LOLOTN", "LOLOTN", JdeDataType.String, 60, true, true),
        new JdeField("LOITM", "LOITM", JdeDataType.Numeric, null, true, true),
        new JdeField("LOMCU", "LOMCU", JdeDataType.String, 24, true, true),
        new JdeField("LOK74CUDE", "LOK74CUDE", JdeDataType.String, 120),
        new JdeField("LOK74CUDJ", "LOK74CUDJ", JdeDataType.Numeric),
        new JdeField("LOK74CUCO", "LOK74CUCO", JdeDataType.String, 6),
        new JdeField("LOUSER", "LOUSER", JdeDataType.String, 20),
        new JdeField("LOPID", "LOPID", JdeDataType.String, 20),
        new JdeField("LOJOBN", "LOJOBN", JdeDataType.String, 20),
        new JdeField("LOUPMJ", "LOUPMJ", JdeDataType.Numeric),
        new JdeField("LOUPMT", "LOUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7464108_0", "Primary Key on LOLOTN, LOITM, LOMCU", new[] { "LOLOTN", "LOITM", "LOMCU" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F7464108_2", "Index on LOLOTN, LOMCU, LOITM", new[] { "LOLOTN", "LOMCU", "LOITM" })
    };
}
