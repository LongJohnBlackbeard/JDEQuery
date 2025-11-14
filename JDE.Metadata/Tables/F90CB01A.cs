using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CB01A - .
/// </summary>
public class F90CB01A : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LAADRSID.
        /// </summary>
        public const string LAADRSID = "LAADRSID";

        /// <summary>
        /// LALEADID.
        /// </summary>
        public const string LALEADID = "LALEADID";

        /// <summary>
        /// LASTSUDT.
        /// </summary>
        public const string LASTSUDT = "LASTSUDT";

        /// <summary>
        /// LAACTIND.
        /// </summary>
        public const string LAACTIND = "LAACTIND";

        /// <summary>
        /// LAUSER.
        /// </summary>
        public const string LAUSER = "LAUSER";

        /// <summary>
        /// LAPID.
        /// </summary>
        public const string LAPID = "LAPID";

        /// <summary>
        /// LAVID.
        /// </summary>
        public const string LAVID = "LAVID";

        /// <summary>
        /// LAMKEY.
        /// </summary>
        public const string LAMKEY = "LAMKEY";

        /// <summary>
        /// LAUDTTM.
        /// </summary>
        public const string LAUDTTM = "LAUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CB01A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LAADRSID", "LAADRSID", JdeDataType.Numeric, null, true, true),
        new JdeField("LALEADID", "LALEADID", JdeDataType.Numeric, null, true, true),
        new JdeField("LASTSUDT", "LASTSUDT", JdeDataType.Date),
        new JdeField("LAACTIND", "LAACTIND", JdeDataType.String, 2),
        new JdeField("LAUSER", "LAUSER", JdeDataType.String, 20),
        new JdeField("LAPID", "LAPID", JdeDataType.String, 20),
        new JdeField("LAVID", "LAVID", JdeDataType.String, 20),
        new JdeField("LAMKEY", "LAMKEY", JdeDataType.String, 30),
        new JdeField("LAUDTTM", "LAUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CB01A_0", "Primary Key on LAADRSID, LALEADID", new[] { "LAADRSID", "LALEADID" }, isUnique: true, isPrimaryKey: true)
    };
}
