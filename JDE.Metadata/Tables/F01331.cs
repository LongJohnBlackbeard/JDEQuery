using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F01331 - .
/// </summary>
public class F01331 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RERECURIDX.
        /// </summary>
        public const string RERECURIDX = "RERECURIDX";

        /// <summary>
        /// RERECURID.
        /// </summary>
        public const string RERECURID = "RERECURID";

        /// <summary>
        /// RETDEX.
        /// </summary>
        public const string RETDEX = "RETDEX";

        /// <summary>
        /// REURCH.
        /// </summary>
        public const string REURCH = "REURCH";

        /// <summary>
        /// REURNUM.
        /// </summary>
        public const string REURNUM = "REURNUM";

        /// <summary>
        /// REURTIME.
        /// </summary>
        public const string REURTIME = "REURTIME";

        /// <summary>
        /// REUDTTM.
        /// </summary>
        public const string REUDTTM = "REUDTTM";

        /// <summary>
        /// REUSER.
        /// </summary>
        public const string REUSER = "REUSER";

        /// <summary>
        /// REEDATE.
        /// </summary>
        public const string REEDATE = "REEDATE";

        /// <summary>
        /// REMKEY.
        /// </summary>
        public const string REMKEY = "REMKEY";

        /// <summary>
        /// REENTDBY.
        /// </summary>
        public const string REENTDBY = "REENTDBY";

        /// <summary>
        /// REACTIVID.
        /// </summary>
        public const string REACTIVID = "REACTIVID";
    }

    /// <inheritdoc />
    public override string TableName => "F01331";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RERECURIDX", "RERECURIDX", JdeDataType.String, 72, true, true),
        new JdeField("RERECURID", "RERECURID", JdeDataType.String, 72, true, true),
        new JdeField("RETDEX", "RETDEX", JdeDataType.Date),
        new JdeField("REURCH", "REURCH", JdeDataType.String, 100),
        new JdeField("REURNUM", "REURNUM", JdeDataType.Numeric),
        new JdeField("REURTIME", "REURTIME", JdeDataType.Date),
        new JdeField("REUDTTM", "REUDTTM", JdeDataType.Date),
        new JdeField("REUSER", "REUSER", JdeDataType.String, 20),
        new JdeField("REEDATE", "REEDATE", JdeDataType.Date),
        new JdeField("REMKEY", "REMKEY", JdeDataType.String, 30),
        new JdeField("REENTDBY", "REENTDBY", JdeDataType.Numeric),
        new JdeField("REACTIVID", "REACTIVID", JdeDataType.String, 72)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F01331_0", "Primary Key on RERECURIDX, RERECURID", new[] { "RERECURIDX", "RERECURID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F01331_2", "Index on RERECURID, REACTIVID", new[] { "RERECURID", "REACTIVID" })
    };
}
