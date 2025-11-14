using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CF070 - .
/// </summary>
public class F90CF070 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CCTKNID.
        /// </summary>
        public const string CCTKNID = "CCTKNID";

        /// <summary>
        /// CCTKNNAM.
        /// </summary>
        public const string CCTKNNAM = "CCTKNNAM";

        /// <summary>
        /// CCTOKNDESC.
        /// </summary>
        public const string CCTOKNDESC = "CCTOKNDESC";

        /// <summary>
        /// CCTKNTYP.
        /// </summary>
        public const string CCTKNTYP = "CCTKNTYP";

        /// <summary>
        /// CCUSER.
        /// </summary>
        public const string CCUSER = "CCUSER";

        /// <summary>
        /// CCUDTTM.
        /// </summary>
        public const string CCUDTTM = "CCUDTTM";

        /// <summary>
        /// CCJOBN.
        /// </summary>
        public const string CCJOBN = "CCJOBN";

        /// <summary>
        /// CCMKEY.
        /// </summary>
        public const string CCMKEY = "CCMKEY";

        /// <summary>
        /// CCTKNFLD.
        /// </summary>
        public const string CCTKNFLD = "CCTKNFLD";
    }

    /// <inheritdoc />
    public override string TableName => "F90CF070";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CCTKNID", "CCTKNID", JdeDataType.Numeric, null, true, true),
        new JdeField("CCTKNNAM", "CCTKNNAM", JdeDataType.String, 60),
        new JdeField("CCTOKNDESC", "CCTOKNDESC", JdeDataType.String, 508),
        new JdeField("CCTKNTYP", "CCTKNTYP", JdeDataType.String, 8),
        new JdeField("CCUSER", "CCUSER", JdeDataType.String, 20),
        new JdeField("CCUDTTM", "CCUDTTM", JdeDataType.Date),
        new JdeField("CCJOBN", "CCJOBN", JdeDataType.String, 20),
        new JdeField("CCMKEY", "CCMKEY", JdeDataType.String, 30),
        new JdeField("CCTKNFLD", "CCTKNFLD", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CF070_0", "Primary Key on CCTKNID", new[] { "CCTKNID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CF070_2", "Index on CCTKNFLD", new[] { "CCTKNFLD" })
    };
}
