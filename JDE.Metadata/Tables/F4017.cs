using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4017 - .
/// </summary>
public class F4017 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// TVINMG.
        /// </summary>
        public const string TVINMG = "TVINMG";

        /// <summary>
        /// TVITM.
        /// </summary>
        public const string TVITM = "TVITM";

        /// <summary>
        /// TVPID.
        /// </summary>
        public const string TVPID = "TVPID";

        /// <summary>
        /// TVDCTO.
        /// </summary>
        public const string TVDCTO = "TVDCTO";

        /// <summary>
        /// TVPNOR.
        /// </summary>
        public const string TVPNOR = "TVPNOR";

        /// <summary>
        /// TVUSER.
        /// </summary>
        public const string TVUSER = "TVUSER";

        /// <summary>
        /// TVJOBN.
        /// </summary>
        public const string TVJOBN = "TVJOBN";

        /// <summary>
        /// TVPIDP.
        /// </summary>
        public const string TVPIDP = "TVPIDP";

        /// <summary>
        /// TVUPMJ.
        /// </summary>
        public const string TVUPMJ = "TVUPMJ";

        /// <summary>
        /// TVTDAY.
        /// </summary>
        public const string TVTDAY = "TVTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4017";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("TVINMG", "TVINMG", JdeDataType.String, 20, true, true),
        new JdeField("TVITM", "TVITM", JdeDataType.Numeric, null, true, true),
        new JdeField("TVPID", "TVPID", JdeDataType.String, 20, true, true),
        new JdeField("TVDCTO", "TVDCTO", JdeDataType.String, 4, true, true),
        new JdeField("TVPNOR", "TVPNOR", JdeDataType.String, 2),
        new JdeField("TVUSER", "TVUSER", JdeDataType.String, 20),
        new JdeField("TVJOBN", "TVJOBN", JdeDataType.String, 20),
        new JdeField("TVPIDP", "TVPIDP", JdeDataType.String, 20),
        new JdeField("TVUPMJ", "TVUPMJ", JdeDataType.Numeric),
        new JdeField("TVTDAY", "TVTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4017_0", "Primary Key on TVINMG, TVITM, TVPID, TVDCTO", new[] { "TVINMG", "TVITM", "TVPID", "TVDCTO" }, isUnique: true, isPrimaryKey: true)
    };
}
