using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA14A - .
/// </summary>
public class F90CA14A : JdeTable
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
        /// TEEMAN8.
        /// </summary>
        public const string TEEMAN8 = "TEEMAN8";

        /// <summary>
        /// TESRLNMBR.
        /// </summary>
        public const string TESRLNMBR = "TESRLNMBR";

        /// <summary>
        /// TESTSUDT.
        /// </summary>
        public const string TESTSUDT = "TESTSUDT";

        /// <summary>
        /// TEACTIND.
        /// </summary>
        public const string TEACTIND = "TEACTIND";

        /// <summary>
        /// TESTMBDT.
        /// </summary>
        public const string TESTMBDT = "TESTMBDT";

        /// <summary>
        /// TESTMEDT.
        /// </summary>
        public const string TESTMEDT = "TESTMEDT";

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
    public override string TableName => "F90CA14A";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TETERRID", "TETERRID", JdeDataType.Numeric, null, true, true),
        new JdeField("TEEMAN8", "TEEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("TESRLNMBR", "TESRLNMBR", JdeDataType.Numeric, null, true, true),
        new JdeField("TESTSUDT", "TESTSUDT", JdeDataType.Date),
        new JdeField("TEACTIND", "TEACTIND", JdeDataType.String, 2),
        new JdeField("TESTMBDT", "TESTMBDT", JdeDataType.Date),
        new JdeField("TESTMEDT", "TESTMEDT", JdeDataType.Date),
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
        new JdeIndex("F90CA14A_0", "Primary Key on TETERRID, TEEMAN8, TESRLNMBR", new[] { "TETERRID", "TEEMAN8", "TESRLNMBR" }, isUnique: true, isPrimaryKey: true)
    };
}
