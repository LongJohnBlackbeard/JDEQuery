using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA14E - .
/// </summary>
public class F90CA14E : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TETERRID.
        /// </summary>
        public const string TETERRID = "TETERRID";

        /// <summary>
        /// TECTY1.
        /// </summary>
        public const string TECTY1 = "TECTY1";

        /// <summary>
        /// TESTDRKY.
        /// </summary>
        public const string TESTDRKY = "TESTDRKY";

        /// <summary>
        /// TEADDZ.
        /// </summary>
        public const string TEADDZ = "TEADDZ";

        /// <summary>
        /// TECOUN.
        /// </summary>
        public const string TECOUN = "TECOUN";

        /// <summary>
        /// TESTSUDT.
        /// </summary>
        public const string TESTSUDT = "TESTSUDT";

        /// <summary>
        /// TEACTIND.
        /// </summary>
        public const string TEACTIND = "TEACTIND";

        /// <summary>
        /// TEUSER.
        /// </summary>
        public const string TEUSER = "TEUSER";

        /// <summary>
        /// TEPID.
        /// </summary>
        public const string TEPID = "TEPID";

        /// <summary>
        /// TEVID.
        /// </summary>
        public const string TEVID = "TEVID";

        /// <summary>
        /// TEMKEY.
        /// </summary>
        public const string TEMKEY = "TEMKEY";

        /// <summary>
        /// TEUDTTM.
        /// </summary>
        public const string TEUDTTM = "TEUDTTM";

        /// <summary>
        /// TEENTDBY.
        /// </summary>
        public const string TEENTDBY = "TEENTDBY";

        /// <summary>
        /// TEEDATE.
        /// </summary>
        public const string TEEDATE = "TEEDATE";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA14E";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TETERRID", "TETERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TECTY1", "TECTY1", JdeDataType.String, 50, true, true),
        new JdeField("TESTDRKY", "TESTDRKY", JdeDataType.String, 20, true, true),
        new JdeField("TEADDZ", "TEADDZ", JdeDataType.String, 24),
        new JdeField("TECOUN", "TECOUN", JdeDataType.String, 50),
        new JdeField("TESTSUDT", "TESTSUDT", JdeDataType.Date),
        new JdeField("TEACTIND", "TEACTIND", JdeDataType.String, 2),
        new JdeField("TEUSER", "TEUSER", JdeDataType.String, 20),
        new JdeField("TEPID", "TEPID", JdeDataType.String, 20),
        new JdeField("TEVID", "TEVID", JdeDataType.String, 20),
        new JdeField("TEMKEY", "TEMKEY", JdeDataType.String, 30),
        new JdeField("TEUDTTM", "TEUDTTM", JdeDataType.Date),
        new JdeField("TEENTDBY", "TEENTDBY", JdeDataType.Numeric),
        new JdeField("TEEDATE", "TEEDATE", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA14E_0", "Primary Key on TETERRID, TECTY1, TESTDRKY", new[] { "TETERRID", "TECTY1", "TESTDRKY" }, isUnique: true, isPrimaryKey: true)
    };
}
