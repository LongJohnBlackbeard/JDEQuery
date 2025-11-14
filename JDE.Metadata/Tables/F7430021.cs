using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F7430021 - .
/// </summary>
public class F7430021 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// DTK74IDFR.
        /// </summary>
        public const string DTK74IDFR = "DTK74IDFR";

        /// <summary>
        /// DTDL01.
        /// </summary>
        public const string DTDL01 = "DTDL01";

        /// <summary>
        /// DTK74DENR.
        /// </summary>
        public const string DTK74DENR = "DTK74DENR";

        /// <summary>
        /// DTK74SAPF.
        /// </summary>
        public const string DTK74SAPF = "DTK74SAPF";

        /// <summary>
        /// DTK74SANR.
        /// </summary>
        public const string DTK74SANR = "DTK74SANR";

        /// <summary>
        /// DTK74DAPF.
        /// </summary>
        public const string DTK74DAPF = "DTK74DAPF";

        /// <summary>
        /// DTK74DANR.
        /// </summary>
        public const string DTK74DANR = "DTK74DANR";

        /// <summary>
        /// DTK74ATLG.
        /// </summary>
        public const string DTK74ATLG = "DTK74ATLG";

        /// <summary>
        /// DTUSER.
        /// </summary>
        public const string DTUSER = "DTUSER";

        /// <summary>
        /// DTPID.
        /// </summary>
        public const string DTPID = "DTPID";

        /// <summary>
        /// DTJOBN.
        /// </summary>
        public const string DTJOBN = "DTJOBN";

        /// <summary>
        /// DTUPMT.
        /// </summary>
        public const string DTUPMT = "DTUPMT";

        /// <summary>
        /// DTUPMJ.
        /// </summary>
        public const string DTUPMJ = "DTUPMJ";
    }

    /// <inheritdoc />
    public override string TableName => "F7430021";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("DTK74IDFR", "DTK74IDFR", JdeDataType.String, 6, true, true),
        new JdeField("DTDL01", "DTDL01", JdeDataType.String, 60),
        new JdeField("DTK74DENR", "DTK74DENR", JdeDataType.Numeric),
        new JdeField("DTK74SAPF", "DTK74SAPF", JdeDataType.String, 2),
        new JdeField("DTK74SANR", "DTK74SANR", JdeDataType.Numeric),
        new JdeField("DTK74DAPF", "DTK74DAPF", JdeDataType.String, 2),
        new JdeField("DTK74DANR", "DTK74DANR", JdeDataType.Numeric),
        new JdeField("DTK74ATLG", "DTK74ATLG", JdeDataType.Numeric),
        new JdeField("DTUSER", "DTUSER", JdeDataType.String, 20),
        new JdeField("DTPID", "DTPID", JdeDataType.String, 20),
        new JdeField("DTJOBN", "DTJOBN", JdeDataType.String, 20),
        new JdeField("DTUPMT", "DTUPMT", JdeDataType.Numeric),
        new JdeField("DTUPMJ", "DTUPMJ", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F7430021_0", "Primary Key on DTK74IDFR", new[] { "DTK74IDFR" }, isUnique: true, isPrimaryKey: true)
    };
}
