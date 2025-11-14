using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CE01A - .
/// </summary>
public class F90CE01A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// WOSLTNID.
        /// </summary>
        public const string WOSLTNID = "WOSLTNID";

        /// <summary>
        /// WODOCO.
        /// </summary>
        public const string WODOCO = "WODOCO";

        /// <summary>
        /// WOENTDBY.
        /// </summary>
        public const string WOENTDBY = "WOENTDBY";

        /// <summary>
        /// WOEDATE.
        /// </summary>
        public const string WOEDATE = "WOEDATE";

        /// <summary>
        /// WOUSER.
        /// </summary>
        public const string WOUSER = "WOUSER";

        /// <summary>
        /// WOUDTTM.
        /// </summary>
        public const string WOUDTTM = "WOUDTTM";

        /// <summary>
        /// WOMKEY.
        /// </summary>
        public const string WOMKEY = "WOMKEY";

        /// <summary>
        /// WOSLLKST.
        /// </summary>
        public const string WOSLLKST = "WOSLLKST";
    }

    /// <inheritdoc />
    public override string TableName => "F90CE01A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("WOSLTNID", "WOSLTNID", JdeDataType.Numeric, null, true, true),
        new JdeField("WODOCO", "WODOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("WOENTDBY", "WOENTDBY", JdeDataType.Numeric),
        new JdeField("WOEDATE", "WOEDATE", JdeDataType.Date),
        new JdeField("WOUSER", "WOUSER", JdeDataType.String, 20),
        new JdeField("WOUDTTM", "WOUDTTM", JdeDataType.Date),
        new JdeField("WOMKEY", "WOMKEY", JdeDataType.String, 30),
        new JdeField("WOSLLKST", "WOSLLKST", JdeDataType.String, 4)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CE01A_0", "Primary Key on WOSLTNID, WODOCO", new[] { "WOSLTNID", "WODOCO" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CE01A_2", "Index on WODOCO", new[] { "WODOCO" })
    };
}
