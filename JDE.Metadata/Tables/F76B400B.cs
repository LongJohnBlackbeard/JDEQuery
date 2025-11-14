using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F76B400B - .
/// </summary>
public class F76B400B : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// IRUKID.
        /// </summary>
        public const string IRUKID = "IRUKID";

        /// <summary>
        /// IRFCO.
        /// </summary>
        public const string IRFCO = "IRFCO";

        /// <summary>
        /// IRBRID.
        /// </summary>
        public const string IRBRID = "IRBRID";

        /// <summary>
        /// IRBRIV.
        /// </summary>
        public const string IRBRIV = "IRBRIV";

        /// <summary>
        /// IRLITM.
        /// </summary>
        public const string IRLITM = "IRLITM";

        /// <summary>
        /// IRUOM1.
        /// </summary>
        public const string IRUOM1 = "IRUOM1";

        /// <summary>
        /// IRCMQT.
        /// </summary>
        public const string IRCMQT = "IRCMQT";

        /// <summary>
        /// IRCUMA.
        /// </summary>
        public const string IRCUMA = "IRCUMA";

        /// <summary>
        /// IRRDOR.
        /// </summary>
        public const string IRRDOR = "IRRDOR";

        /// <summary>
        /// IRC1FU.
        /// </summary>
        public const string IRC1FU = "IRC1FU";

        /// <summary>
        /// IRC2FU.
        /// </summary>
        public const string IRC2FU = "IRC2FU";

        /// <summary>
        /// IRD1FU.
        /// </summary>
        public const string IRD1FU = "IRD1FU";

        /// <summary>
        /// IRD2FU.
        /// </summary>
        public const string IRD2FU = "IRD2FU";

        /// <summary>
        /// IRN1FU.
        /// </summary>
        public const string IRN1FU = "IRN1FU";

        /// <summary>
        /// IRN2FU.
        /// </summary>
        public const string IRN2FU = "IRN2FU";

        /// <summary>
        /// IRN3FU.
        /// </summary>
        public const string IRN3FU = "IRN3FU";

        /// <summary>
        /// IRN4FU.
        /// </summary>
        public const string IRN4FU = "IRN4FU";

        /// <summary>
        /// IRN5FU.
        /// </summary>
        public const string IRN5FU = "IRN5FU";

        /// <summary>
        /// IRN6FU.
        /// </summary>
        public const string IRN6FU = "IRN6FU";

        /// <summary>
        /// IRN7FU.
        /// </summary>
        public const string IRN7FU = "IRN7FU";

        /// <summary>
        /// IRS1FU.
        /// </summary>
        public const string IRS1FU = "IRS1FU";

        /// <summary>
        /// IRS2FU.
        /// </summary>
        public const string IRS2FU = "IRS2FU";

        /// <summary>
        /// IRS3FU.
        /// </summary>
        public const string IRS3FU = "IRS3FU";

        /// <summary>
        /// IRS4FU.
        /// </summary>
        public const string IRS4FU = "IRS4FU";

        /// <summary>
        /// IRGENLNG.
        /// </summary>
        public const string IRGENLNG = "IRGENLNG";

        /// <summary>
        /// IRTORG.
        /// </summary>
        public const string IRTORG = "IRTORG";

        /// <summary>
        /// IRUSER.
        /// </summary>
        public const string IRUSER = "IRUSER";

        /// <summary>
        /// IRPID.
        /// </summary>
        public const string IRPID = "IRPID";

        /// <summary>
        /// IRJOBN.
        /// </summary>
        public const string IRJOBN = "IRJOBN";

        /// <summary>
        /// IRUPMJ.
        /// </summary>
        public const string IRUPMJ = "IRUPMJ";

        /// <summary>
        /// IRUPMT.
        /// </summary>
        public const string IRUPMT = "IRUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F76B400B";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("IRUKID", "IRUKID", JdeDataType.Numeric, null, true, true),
        new JdeField("IRFCO", "IRFCO", JdeDataType.String, 10),
        new JdeField("IRBRID", "IRBRID", JdeDataType.Numeric),
        new JdeField("IRBRIV", "IRBRIV", JdeDataType.String, 20),
        new JdeField("IRLITM", "IRLITM", JdeDataType.String, 50),
        new JdeField("IRUOM1", "IRUOM1", JdeDataType.String, 4),
        new JdeField("IRCMQT", "IRCMQT", JdeDataType.Numeric),
        new JdeField("IRCUMA", "IRCUMA", JdeDataType.Numeric),
        new JdeField("IRRDOR", "IRRDOR", JdeDataType.String, 2),
        new JdeField("IRC1FU", "IRC1FU", JdeDataType.String, 2),
        new JdeField("IRC2FU", "IRC2FU", JdeDataType.String, 2),
        new JdeField("IRD1FU", "IRD1FU", JdeDataType.Numeric),
        new JdeField("IRD2FU", "IRD2FU", JdeDataType.Numeric),
        new JdeField("IRN1FU", "IRN1FU", JdeDataType.Numeric),
        new JdeField("IRN2FU", "IRN2FU", JdeDataType.Numeric),
        new JdeField("IRN3FU", "IRN3FU", JdeDataType.Numeric),
        new JdeField("IRN4FU", "IRN4FU", JdeDataType.Numeric),
        new JdeField("IRN5FU", "IRN5FU", JdeDataType.Numeric),
        new JdeField("IRN6FU", "IRN6FU", JdeDataType.Numeric),
        new JdeField("IRN7FU", "IRN7FU", JdeDataType.Numeric),
        new JdeField("IRS1FU", "IRS1FU", JdeDataType.String, 60),
        new JdeField("IRS2FU", "IRS2FU", JdeDataType.String, 60),
        new JdeField("IRS3FU", "IRS3FU", JdeDataType.String, 6),
        new JdeField("IRS4FU", "IRS4FU", JdeDataType.String, 6),
        new JdeField("IRGENLNG", "IRGENLNG", JdeDataType.Numeric),
        new JdeField("IRTORG", "IRTORG", JdeDataType.String, 20),
        new JdeField("IRUSER", "IRUSER", JdeDataType.String, 20),
        new JdeField("IRPID", "IRPID", JdeDataType.String, 20),
        new JdeField("IRJOBN", "IRJOBN", JdeDataType.String, 20),
        new JdeField("IRUPMJ", "IRUPMJ", JdeDataType.Numeric),
        new JdeField("IRUPMT", "IRUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F76B400B_0", "Primary Key on IRUKID", new[] { "IRUKID" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F76B400B_2", "Unique Index on IRFCO, IRBRID, IRLITM, IRBRIV", new[] { "IRFCO", "IRBRID", "IRLITM", "IRBRIV" }, isUnique: true)
    };
}
