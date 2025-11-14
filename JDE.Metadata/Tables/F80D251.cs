using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F80D251 - .
/// </summary>
public class F80D251 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PLPRDJ.
        /// </summary>
        public const string PLPRDJ = "PLPRDJ";

        /// <summary>
        /// PLMCU.
        /// </summary>
        public const string PLMCU = "PLMCU";

        /// <summary>
        /// PLITM.
        /// </summary>
        public const string PLITM = "PLITM";

        /// <summary>
        /// PLAN8.
        /// </summary>
        public const string PLAN8 = "PLAN8";

        /// <summary>
        /// PLRLTD.
        /// </summary>
        public const string PLRLTD = "PLRLTD";

        /// <summary>
        /// PLRECLTE.
        /// </summary>
        public const string PLRECLTE = "PLRECLTE";

        /// <summary>
        /// PLRECSTE.
        /// </summary>
        public const string PLRECSTE = "PLRECSTE";

        /// <summary>
        /// PLRECV.
        /// </summary>
        public const string PLRECV = "PLRECV";

        /// <summary>
        /// PLUSER.
        /// </summary>
        public const string PLUSER = "PLUSER";

        /// <summary>
        /// PLPID.
        /// </summary>
        public const string PLPID = "PLPID";

        /// <summary>
        /// PLMKEY.
        /// </summary>
        public const string PLMKEY = "PLMKEY";

        /// <summary>
        /// PLUTIME.
        /// </summary>
        public const string PLUTIME = "PLUTIME";

        /// <summary>
        /// PLURCD.
        /// </summary>
        public const string PLURCD = "PLURCD";

        /// <summary>
        /// PLURDT.
        /// </summary>
        public const string PLURDT = "PLURDT";

        /// <summary>
        /// PLURAT.
        /// </summary>
        public const string PLURAT = "PLURAT";

        /// <summary>
        /// PLURAB.
        /// </summary>
        public const string PLURAB = "PLURAB";

        /// <summary>
        /// PLURRF.
        /// </summary>
        public const string PLURRF = "PLURRF";
    }

    /// <inheritdoc />
    public override string TableName => "F80D251";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PLPRDJ", "PLPRDJ", JdeDataType.Numeric, null, true, true),
        new JdeField("PLMCU", "PLMCU", JdeDataType.String, 24, true, true),
        new JdeField("PLITM", "PLITM", JdeDataType.Numeric, null, true, true),
        new JdeField("PLAN8", "PLAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PLRLTD", "PLRLTD", JdeDataType.Numeric),
        new JdeField("PLRECLTE", "PLRECLTE", JdeDataType.Numeric),
        new JdeField("PLRECSTE", "PLRECSTE", JdeDataType.Numeric),
        new JdeField("PLRECV", "PLRECV", JdeDataType.Numeric),
        new JdeField("PLUSER", "PLUSER", JdeDataType.String, 20),
        new JdeField("PLPID", "PLPID", JdeDataType.String, 20),
        new JdeField("PLMKEY", "PLMKEY", JdeDataType.String, 30),
        new JdeField("PLUTIME", "PLUTIME", JdeDataType.Date),
        new JdeField("PLURCD", "PLURCD", JdeDataType.String, 4),
        new JdeField("PLURDT", "PLURDT", JdeDataType.Numeric),
        new JdeField("PLURAT", "PLURAT", JdeDataType.Numeric),
        new JdeField("PLURAB", "PLURAB", JdeDataType.Numeric),
        new JdeField("PLURRF", "PLURRF", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F80D251_0", "Primary Key on PLPRDJ, PLMCU, PLITM, PLAN8", new[] { "PLPRDJ", "PLMCU", "PLITM", "PLAN8" }, isUnique: true, isPrimaryKey: true)
    };
}
