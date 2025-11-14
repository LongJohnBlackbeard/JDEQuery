using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CA041 - .
/// </summary>
public class F90CA041 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ESCFGSID.
        /// </summary>
        public const string ESCFGSID = "ESCFGSID";

        /// <summary>
        /// ESEMAN8.
        /// </summary>
        public const string ESEMAN8 = "ESEMAN8";

        /// <summary>
        /// ESALPH.
        /// </summary>
        public const string ESALPH = "ESALPH";

        /// <summary>
        /// ESENTDBY.
        /// </summary>
        public const string ESENTDBY = "ESENTDBY";

        /// <summary>
        /// ESEDATE.
        /// </summary>
        public const string ESEDATE = "ESEDATE";

        /// <summary>
        /// ESUSER.
        /// </summary>
        public const string ESUSER = "ESUSER";

        /// <summary>
        /// ESPID.
        /// </summary>
        public const string ESPID = "ESPID";

        /// <summary>
        /// ESVID.
        /// </summary>
        public const string ESVID = "ESVID";

        /// <summary>
        /// ESMKEY.
        /// </summary>
        public const string ESMKEY = "ESMKEY";

        /// <summary>
        /// ESUDTTM.
        /// </summary>
        public const string ESUDTTM = "ESUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CA041";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ESCFGSID", "ESCFGSID", JdeDataType.String, 64, true, true),
        new JdeField("ESEMAN8", "ESEMAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ESALPH", "ESALPH", JdeDataType.String, 80),
        new JdeField("ESENTDBY", "ESENTDBY", JdeDataType.Numeric),
        new JdeField("ESEDATE", "ESEDATE", JdeDataType.Date),
        new JdeField("ESUSER", "ESUSER", JdeDataType.String, 20),
        new JdeField("ESPID", "ESPID", JdeDataType.String, 20),
        new JdeField("ESVID", "ESVID", JdeDataType.String, 20),
        new JdeField("ESMKEY", "ESMKEY", JdeDataType.String, 30),
        new JdeField("ESUDTTM", "ESUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CA041_0", "Primary Key on ESCFGSID, ESEMAN8", new[] { "ESCFGSID", "ESEMAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
