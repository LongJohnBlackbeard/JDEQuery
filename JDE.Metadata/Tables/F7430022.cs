using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430022 - .
/// </summary>
public class F7430022 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DLK74IDFR.
        /// </summary>
        public const string DLK74IDFR = "DLK74IDFR";

        /// <summary>
        /// DLK74LTFR.
        /// </summary>
        public const string DLK74LTFR = "DLK74LTFR";

        /// <summary>
        /// DLK74LTNR.
        /// </summary>
        public const string DLK74LTNR = "DLK74LTNR";

        /// <summary>
        /// DLUSER.
        /// </summary>
        public const string DLUSER = "DLUSER";

        /// <summary>
        /// DLPID.
        /// </summary>
        public const string DLPID = "DLPID";

        /// <summary>
        /// DLJOBN.
        /// </summary>
        public const string DLJOBN = "DLJOBN";

        /// <summary>
        /// DLUPMT.
        /// </summary>
        public const string DLUPMT = "DLUPMT";

        /// <summary>
        /// DLUPMJ.
        /// </summary>
        public const string DLUPMJ = "DLUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7430022";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DLK74IDFR", "DLK74IDFR", JdeDataType.String, 6, true, true),
        new JdeField("DLK74LTFR", "DLK74LTFR", JdeDataType.String, 6, true, true),
        new JdeField("DLK74LTNR", "DLK74LTNR", JdeDataType.Numeric),
        new JdeField("DLUSER", "DLUSER", JdeDataType.String, 20),
        new JdeField("DLPID", "DLPID", JdeDataType.String, 20),
        new JdeField("DLJOBN", "DLJOBN", JdeDataType.String, 20),
        new JdeField("DLUPMT", "DLUPMT", JdeDataType.Numeric),
        new JdeField("DLUPMJ", "DLUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430022_0", "Primary Key on DLK74IDFR, DLK74LTFR", new[] { "DLK74IDFR", "DLK74LTFR" }, isUnique: true, isPrimaryKey: true)
    };
}
