using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F49T90 - .
/// </summary>
public class F49T90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ITDATETIME.
        /// </summary>
        public const string ITDATETIME = "ITDATETIME";

        /// <summary>
        /// ITTRMNUM.
        /// </summary>
        public const string ITTRMNUM = "ITTRMNUM";

        /// <summary>
        /// ITDOCBLOB.
        /// </summary>
        public const string ITDOCBLOB = "ITDOCBLOB";

        /// <summary>
        /// ITERRC.
        /// </summary>
        public const string ITERRC = "ITERRC";

        /// <summary>
        /// ITOTXMLTYP.
        /// </summary>
        public const string ITOTXMLTYP = "ITOTXMLTYP";
    }

    /// <inheritdoc />
    public override string TableName => "F49T90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ITDATETIME", "ITDATETIME", JdeDataType.String, 52, true, true),
        new JdeField("ITTRMNUM", "ITTRMNUM", JdeDataType.String, 22, true, true),
        new JdeField("ITDOCBLOB", "ITDOCBLOB", JdeDataType.String),
        new JdeField("ITERRC", "ITERRC", JdeDataType.String, 2),
        new JdeField("ITOTXMLTYP", "ITOTXMLTYP", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F49T90_0", "Primary Key on ITDATETIME, ITTRMNUM", new[] { "ITDATETIME", "ITTRMNUM" }, isUnique: true, isPrimaryKey: true)
    };
}
