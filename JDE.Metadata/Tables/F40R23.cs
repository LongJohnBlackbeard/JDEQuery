using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F40R23 - .
/// </summary>
public class F40R23 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PCMCU.
        /// </summary>
        public const string PCMCU = "PCMCU";

        /// <summary>
        /// PCAN8.
        /// </summary>
        public const string PCAN8 = "PCAN8";

        /// <summary>
        /// PCSHAN.
        /// </summary>
        public const string PCSHAN = "PCSHAN";

        /// <summary>
        /// PCCUMBYST.
        /// </summary>
        public const string PCCUMBYST = "PCCUMBYST";

        /// <summary>
        /// PCCUMBYPO.
        /// </summary>
        public const string PCCUMBYPO = "PCCUMBYPO";

        /// <summary>
        /// PCCUMUT1.
        /// </summary>
        public const string PCCUMUT1 = "PCCUMUT1";

        /// <summary>
        /// PCCUMUT2.
        /// </summary>
        public const string PCCUMUT2 = "PCCUMUT2";

        /// <summary>
        /// PCCUMUT3.
        /// </summary>
        public const string PCCUMUT3 = "PCCUMUT3";

        /// <summary>
        /// PCTRKCUM.
        /// </summary>
        public const string PCTRKCUM = "PCTRKCUM";

        /// <summary>
        /// PCURCD.
        /// </summary>
        public const string PCURCD = "PCURCD";

        /// <summary>
        /// PCURDT.
        /// </summary>
        public const string PCURDT = "PCURDT";

        /// <summary>
        /// PCURAT.
        /// </summary>
        public const string PCURAT = "PCURAT";

        /// <summary>
        /// PCURAB.
        /// </summary>
        public const string PCURAB = "PCURAB";

        /// <summary>
        /// PCURRF.
        /// </summary>
        public const string PCURRF = "PCURRF";

        /// <summary>
        /// PCUSER.
        /// </summary>
        public const string PCUSER = "PCUSER";

        /// <summary>
        /// PCPID.
        /// </summary>
        public const string PCPID = "PCPID";

        /// <summary>
        /// PCJOBN.
        /// </summary>
        public const string PCJOBN = "PCJOBN";

        /// <summary>
        /// PCUPMJ.
        /// </summary>
        public const string PCUPMJ = "PCUPMJ";

        /// <summary>
        /// PCTDAY.
        /// </summary>
        public const string PCTDAY = "PCTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F40R23";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PCMCU", "PCMCU", JdeDataType.String, 24, true, true),
        new JdeField("PCAN8", "PCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("PCSHAN", "PCSHAN", JdeDataType.Numeric, null, true, true),
        new JdeField("PCCUMBYST", "PCCUMBYST", JdeDataType.String, 2),
        new JdeField("PCCUMBYPO", "PCCUMBYPO", JdeDataType.String, 2),
        new JdeField("PCCUMUT1", "PCCUMUT1", JdeDataType.String, 6),
        new JdeField("PCCUMUT2", "PCCUMUT2", JdeDataType.String, 6),
        new JdeField("PCCUMUT3", "PCCUMUT3", JdeDataType.String, 6),
        new JdeField("PCTRKCUM", "PCTRKCUM", JdeDataType.String, 2),
        new JdeField("PCURCD", "PCURCD", JdeDataType.String, 4),
        new JdeField("PCURDT", "PCURDT", JdeDataType.Numeric),
        new JdeField("PCURAT", "PCURAT", JdeDataType.Numeric),
        new JdeField("PCURAB", "PCURAB", JdeDataType.Numeric),
        new JdeField("PCURRF", "PCURRF", JdeDataType.String, 30),
        new JdeField("PCUSER", "PCUSER", JdeDataType.String, 20),
        new JdeField("PCPID", "PCPID", JdeDataType.String, 20),
        new JdeField("PCJOBN", "PCJOBN", JdeDataType.String, 20),
        new JdeField("PCUPMJ", "PCUPMJ", JdeDataType.Numeric),
        new JdeField("PCTDAY", "PCTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F40R23_0", "Primary Key on PCMCU, PCAN8, PCSHAN", new[] { "PCMCU", "PCAN8", "PCSHAN" }, isUnique: true, isPrimaryKey: true)
    };
}
