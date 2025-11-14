using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F097041W - .
/// </summary>
public class F097041W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ABUSER.
        /// </summary>
        public const string ABUSER = "ABUSER";

        /// <summary>
        /// ABUKID.
        /// </summary>
        public const string ABUKID = "ABUKID";

        /// <summary>
        /// ABAID.
        /// </summary>
        public const string ABAID = "ABAID";

        /// <summary>
        /// ABMCU.
        /// </summary>
        public const string ABMCU = "ABMCU";

        /// <summary>
        /// ABOBJ.
        /// </summary>
        public const string ABOBJ = "ABOBJ";

        /// <summary>
        /// ABSUB.
        /// </summary>
        public const string ABSUB = "ABSUB";

        /// <summary>
        /// ABAMCO.
        /// </summary>
        public const string ABAMCO = "ABAMCO";

        /// <summary>
        /// ABBUMCO.
        /// </summary>
        public const string ABBUMCO = "ABBUMCO";

        /// <summary>
        /// ABLDA.
        /// </summary>
        public const string ABLDA = "ABLDA";

        /// <summary>
        /// ABDL01.
        /// </summary>
        public const string ABDL01 = "ABDL01";
    }

    /// <inheritdoc />
    public override string TableName => "F097041W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ABUSER", "ABUSER", JdeDataType.String, 20, true, true),
        new JdeField("ABUKID", "ABUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("ABAID", "ABAID", JdeDataType.String, 16, true, true),
        new JdeField("ABMCU", "ABMCU", JdeDataType.String, 24),
        new JdeField("ABOBJ", "ABOBJ", JdeDataType.String, 12),
        new JdeField("ABSUB", "ABSUB", JdeDataType.String, 16),
        new JdeField("ABAMCO", "ABAMCO", JdeDataType.String, 10),
        new JdeField("ABBUMCO", "ABBUMCO", JdeDataType.String, 10),
        new JdeField("ABLDA", "ABLDA", JdeDataType.String, 2),
        new JdeField("ABDL01", "ABDL01", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F097041W_0", "Primary Key on ABUSER, ABUKID, ABAID", new[] { "ABUSER", "ABUKID", "ABAID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F097041W_2", "Index on ABUSER, ABUKID, ABMCU, ABOBJ, ABSUB", new[] { "ABUSER", "ABUKID", "ABMCU", "ABOBJ", "ABSUB" })
    };
}
