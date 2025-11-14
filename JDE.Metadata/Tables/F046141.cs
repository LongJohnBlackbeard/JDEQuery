using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F046141 - .
/// </summary>
public class F046141 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CUCO.
        /// </summary>
        public const string CUCO = "CUCO";

        /// <summary>
        /// CUCBNP.
        /// </summary>
        public const string CUCBNP = "CUCBNP";

        /// <summary>
        /// CUAN8.
        /// </summary>
        public const string CUAN8 = "CUAN8";

        /// <summary>
        /// CUCBNR.
        /// </summary>
        public const string CUCBNR = "CUCBNR";

        /// <summary>
        /// CUSINI.
        /// </summary>
        public const string CUSINI = "CUSINI";

        /// <summary>
        /// CUAA.
        /// </summary>
        public const string CUAA = "CUAA";

        /// <summary>
        /// CURTYPC.
        /// </summary>
        public const string CURTYPC = "CURTYPC";

        /// <summary>
        /// CUSRCSY.
        /// </summary>
        public const string CUSRCSY = "CUSRCSY";

        /// <summary>
        /// CUUPMJ.
        /// </summary>
        public const string CUUPMJ = "CUUPMJ";

        /// <summary>
        /// CUUPMT.
        /// </summary>
        public const string CUUPMT = "CUUPMT";

        /// <summary>
        /// CUPID.
        /// </summary>
        public const string CUPID = "CUPID";

        /// <summary>
        /// CUUSER.
        /// </summary>
        public const string CUUSER = "CUUSER";

        /// <summary>
        /// CUJOBN.
        /// </summary>
        public const string CUJOBN = "CUJOBN";
    }

    /// <inheritdoc />
    public override string TableName => "F046141";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CUCO", "CUCO", JdeDataType.String, 10, true, true),
        new JdeField("CUCBNP", "CUCBNP", JdeDataType.String, 30),
        new JdeField("CUAN8", "CUAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("CUCBNR", "CUCBNR", JdeDataType.String, 30),
        new JdeField("CUSINI", "CUSINI", JdeDataType.String, 2),
        new JdeField("CUAA", "CUAA", JdeDataType.Numeric),
        new JdeField("CURTYPC", "CURTYPC", JdeDataType.String, 2),
        new JdeField("CUSRCSY", "CUSRCSY", JdeDataType.String, 2, true, true),
        new JdeField("CUUPMJ", "CUUPMJ", JdeDataType.Numeric),
        new JdeField("CUUPMT", "CUUPMT", JdeDataType.Numeric),
        new JdeField("CUPID", "CUPID", JdeDataType.String, 20),
        new JdeField("CUUSER", "CUUSER", JdeDataType.String, 20),
        new JdeField("CUJOBN", "CUJOBN", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F046141_0", "Primary Key on CUAN8, CUCO, CUSRCSY", new[] { "CUAN8", "CUCO", "CUSRCSY" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F046141_2", "Index on CUCBNP, CUCBNR", new[] { "CUCBNP", "CUCBNR" })
    };
}
