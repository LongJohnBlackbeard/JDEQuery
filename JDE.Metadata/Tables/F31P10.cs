using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F31P10 - .
/// </summary>
public class F31P10 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// PQPRJM.
        /// </summary>
        public const string PQPRJM = "PQPRJM";

        /// <summary>
        /// PQQVER.
        /// </summary>
        public const string PQQVER = "PQQVER";

        /// <summary>
        /// PQDOCO.
        /// </summary>
        public const string PQDOCO = "PQDOCO";

        /// <summary>
        /// PQDCTO.
        /// </summary>
        public const string PQDCTO = "PQDCTO";

        /// <summary>
        /// PQMCU.
        /// </summary>
        public const string PQMCU = "PQMCU";

        /// <summary>
        /// PQQAMT.
        /// </summary>
        public const string PQQAMT = "PQQAMT";

        /// <summary>
        /// PQDL01.
        /// </summary>
        public const string PQDL01 = "PQDL01";

        /// <summary>
        /// PQDL02.
        /// </summary>
        public const string PQDL02 = "PQDL02";

        /// <summary>
        /// PQCRR.
        /// </summary>
        public const string PQCRR = "PQCRR";

        /// <summary>
        /// PQCRCD.
        /// </summary>
        public const string PQCRCD = "PQCRCD";

        /// <summary>
        /// PQCRDC.
        /// </summary>
        public const string PQCRDC = "PQCRDC";

        /// <summary>
        /// PQCRRM.
        /// </summary>
        public const string PQCRRM = "PQCRRM";

        /// <summary>
        /// PQCRCM.
        /// </summary>
        public const string PQCRCM = "PQCRCM";

        /// <summary>
        /// PQDISCT.
        /// </summary>
        public const string PQDISCT = "PQDISCT";

        /// <summary>
        /// PQQTSU.
        /// </summary>
        public const string PQQTSU = "PQQTSU";

        /// <summary>
        /// PQAN8.
        /// </summary>
        public const string PQAN8 = "PQAN8";

        /// <summary>
        /// PQANSA.
        /// </summary>
        public const string PQANSA = "PQANSA";

        /// <summary>
        /// PQANO.
        /// </summary>
        public const string PQANO = "PQANO";

        /// <summary>
        /// PQQEFR.
        /// </summary>
        public const string PQQEFR = "PQQEFR";

        /// <summary>
        /// PQQEFT.
        /// </summary>
        public const string PQQEFT = "PQQEFT";

        /// <summary>
        /// PQRORN.
        /// </summary>
        public const string PQRORN = "PQRORN";

        /// <summary>
        /// PQRCTO.
        /// </summary>
        public const string PQRCTO = "PQRCTO";

        /// <summary>
        /// PQRKCO.
        /// </summary>
        public const string PQRKCO = "PQRKCO";

        /// <summary>
        /// PQOSTP.
        /// </summary>
        public const string PQOSTP = "PQOSTP";

        /// <summary>
        /// PQRCQI.
        /// </summary>
        public const string PQRCQI = "PQRCQI";

        /// <summary>
        /// PQRTQI.
        /// </summary>
        public const string PQRTQI = "PQRTQI";

        /// <summary>
        /// PQURCD.
        /// </summary>
        public const string PQURCD = "PQURCD";

        /// <summary>
        /// PQURDT.
        /// </summary>
        public const string PQURDT = "PQURDT";

        /// <summary>
        /// PQURAT.
        /// </summary>
        public const string PQURAT = "PQURAT";

        /// <summary>
        /// PQURAB.
        /// </summary>
        public const string PQURAB = "PQURAB";

        /// <summary>
        /// PQURRF.
        /// </summary>
        public const string PQURRF = "PQURRF";

        /// <summary>
        /// PQUSER.
        /// </summary>
        public const string PQUSER = "PQUSER";

        /// <summary>
        /// PQJOBN.
        /// </summary>
        public const string PQJOBN = "PQJOBN";

        /// <summary>
        /// PQPID.
        /// </summary>
        public const string PQPID = "PQPID";

        /// <summary>
        /// PQUPMJ.
        /// </summary>
        public const string PQUPMJ = "PQUPMJ";

        /// <summary>
        /// PQTDAY.
        /// </summary>
        public const string PQTDAY = "PQTDAY";

        /// <summary>
        /// PQPSTAT.
        /// </summary>
        public const string PQPSTAT = "PQPSTAT";
    }

    /// <inheritdoc />
    public override string TableName => "F31P10";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("PQPRJM", "PQPRJM", JdeDataType.Numeric, null, true, true),
        new JdeField("PQQVER", "PQQVER", JdeDataType.String, 20, true, true),
        new JdeField("PQDOCO", "PQDOCO", JdeDataType.Numeric),
        new JdeField("PQDCTO", "PQDCTO", JdeDataType.String, 4),
        new JdeField("PQMCU", "PQMCU", JdeDataType.String, 24),
        new JdeField("PQQAMT", "PQQAMT", JdeDataType.Numeric),
        new JdeField("PQDL01", "PQDL01", JdeDataType.String, 60),
        new JdeField("PQDL02", "PQDL02", JdeDataType.String, 60),
        new JdeField("PQCRR", "PQCRR", JdeDataType.Numeric),
        new JdeField("PQCRCD", "PQCRCD", JdeDataType.String, 6),
        new JdeField("PQCRDC", "PQCRDC", JdeDataType.String, 6),
        new JdeField("PQCRRM", "PQCRRM", JdeDataType.String, 2),
        new JdeField("PQCRCM", "PQCRCM", JdeDataType.String, 2),
        new JdeField("PQDISCT", "PQDISCT", JdeDataType.String, 2),
        new JdeField("PQQTSU", "PQQTSU", JdeDataType.String, 4),
        new JdeField("PQAN8", "PQAN8", JdeDataType.Numeric),
        new JdeField("PQANSA", "PQANSA", JdeDataType.Numeric),
        new JdeField("PQANO", "PQANO", JdeDataType.Numeric),
        new JdeField("PQQEFR", "PQQEFR", JdeDataType.Numeric),
        new JdeField("PQQEFT", "PQQEFT", JdeDataType.Numeric),
        new JdeField("PQRORN", "PQRORN", JdeDataType.String, 16),
        new JdeField("PQRCTO", "PQRCTO", JdeDataType.String, 4),
        new JdeField("PQRKCO", "PQRKCO", JdeDataType.String, 10),
        new JdeField("PQOSTP", "PQOSTP", JdeDataType.String, 6),
        new JdeField("PQRCQI", "PQRCQI", JdeDataType.String, 4),
        new JdeField("PQRTQI", "PQRTQI", JdeDataType.String, 100),
        new JdeField("PQURCD", "PQURCD", JdeDataType.String, 4),
        new JdeField("PQURDT", "PQURDT", JdeDataType.Numeric),
        new JdeField("PQURAT", "PQURAT", JdeDataType.Numeric),
        new JdeField("PQURAB", "PQURAB", JdeDataType.Numeric),
        new JdeField("PQURRF", "PQURRF", JdeDataType.String, 30),
        new JdeField("PQUSER", "PQUSER", JdeDataType.String, 20),
        new JdeField("PQJOBN", "PQJOBN", JdeDataType.String, 20),
        new JdeField("PQPID", "PQPID", JdeDataType.String, 20),
        new JdeField("PQUPMJ", "PQUPMJ", JdeDataType.Numeric),
        new JdeField("PQTDAY", "PQTDAY", JdeDataType.Numeric),
        new JdeField("PQPSTAT", "PQPSTAT", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F31P10_0", "Primary Key on PQPRJM, PQQVER", new[] { "PQPRJM", "PQQVER" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F31P10_2", "Index on PQPRJM, PQQTSU", new[] { "PQPRJM", "PQQTSU" }),
        new JdeIndex("F31P10_3", "Index on PQRORN, PQRCTO, PQRKCO", new[] { "PQRORN", "PQRCTO", "PQRKCO" }),
        new JdeIndex("F31P10_4", "Index on PQPRJM, PQRORN, PQRCTO", new[] { "PQPRJM", "PQRORN", "PQRCTO" })
    };
}
