using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F90CG506 - .
/// </summary>
public class F90CG506 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ZCAN8.
        /// </summary>
        public const string ZCAN8 = "ZCAN8";

        /// <summary>
        /// ZCAN80.
        /// </summary>
        public const string ZCAN80 = "ZCAN80";

        /// <summary>
        /// ZCSKLVL.
        /// </summary>
        public const string ZCSKLVL = "ZCSKLVL";

        /// <summary>
        /// ZCMGRFLG.
        /// </summary>
        public const string ZCMGRFLG = "ZCMGRFLG";

        /// <summary>
        /// ZCUNVLFLG.
        /// </summary>
        public const string ZCUNVLFLG = "ZCUNVLFLG";

        /// <summary>
        /// ZCCRTU.
        /// </summary>
        public const string ZCCRTU = "ZCCRTU";

        /// <summary>
        /// ZCPID.
        /// </summary>
        public const string ZCPID = "ZCPID";

        /// <summary>
        /// ZCMKEY.
        /// </summary>
        public const string ZCMKEY = "ZCMKEY";

        /// <summary>
        /// ZCUSER.
        /// </summary>
        public const string ZCUSER = "ZCUSER";

        /// <summary>
        /// ZCUDTTM.
        /// </summary>
        public const string ZCUDTTM = "ZCUDTTM";
    }

    /// <inheritdoc />
    public override string TableName => "F90CG506";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ZCAN8", "ZCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCAN80", "ZCAN80", JdeDataType.Numeric, null, true, true),
        new JdeField("ZCSKLVL", "ZCSKLVL", JdeDataType.Numeric),
        new JdeField("ZCMGRFLG", "ZCMGRFLG", JdeDataType.String, 2),
        new JdeField("ZCUNVLFLG", "ZCUNVLFLG", JdeDataType.String, 2),
        new JdeField("ZCCRTU", "ZCCRTU", JdeDataType.String, 20),
        new JdeField("ZCPID", "ZCPID", JdeDataType.String, 20),
        new JdeField("ZCMKEY", "ZCMKEY", JdeDataType.String, 30),
        new JdeField("ZCUSER", "ZCUSER", JdeDataType.String, 20),
        new JdeField("ZCUDTTM", "ZCUDTTM", JdeDataType.Date)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F90CG506_0", "Primary Key on ZCAN8, ZCAN80", new[] { "ZCAN8", "ZCAN80" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F90CG506_2", "Index on ZCAN80", new[] { "ZCAN80" })
    };
}
