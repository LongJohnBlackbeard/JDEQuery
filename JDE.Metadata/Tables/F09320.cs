using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09320 - .
/// </summary>
public class F09320 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// CSCSTN.
        /// </summary>
        public const string CSCSTN = "CSCSTN";

        /// <summary>
        /// CSCSTDC.
        /// </summary>
        public const string CSCSTDC = "CSCSTDC";

        /// <summary>
        /// CSFRLT.
        /// </summary>
        public const string CSFRLT = "CSFRLT";

        /// <summary>
        /// CSFYOFF.
        /// </summary>
        public const string CSFYOFF = "CSFYOFF";

        /// <summary>
        /// CSPNOFF.
        /// </summary>
        public const string CSPNOFF = "CSPNOFF";

        /// <summary>
        /// CSQTOFF.
        /// </summary>
        public const string CSQTOFF = "CSQTOFF";

        /// <summary>
        /// CSBLNOP.
        /// </summary>
        public const string CSBLNOP = "CSBLNOP";

        /// <summary>
        /// CSCSTIT.
        /// </summary>
        public const string CSCSTIT = "CSCSTIT";

        /// <summary>
        /// CSQRYE.
        /// </summary>
        public const string CSQRYE = "CSQRYE";

        /// <summary>
        /// CSSTMSG.
        /// </summary>
        public const string CSSTMSG = "CSSTMSG";

        /// <summary>
        /// CSFRCC1.
        /// </summary>
        public const string CSFRCC1 = "CSFRCC1";

        /// <summary>
        /// CSFRCC2.
        /// </summary>
        public const string CSFRCC2 = "CSFRCC2";

        /// <summary>
        /// CSFRCC3.
        /// </summary>
        public const string CSFRCC3 = "CSFRCC3";

        /// <summary>
        /// CSFRCC4.
        /// </summary>
        public const string CSFRCC4 = "CSFRCC4";

        /// <summary>
        /// CSFRCC5.
        /// </summary>
        public const string CSFRCC5 = "CSFRCC5";

        /// <summary>
        /// CSWOBNM.
        /// </summary>
        public const string CSWOBNM = "CSWOBNM";

        /// <summary>
        /// CSCDNU1.
        /// </summary>
        public const string CSCDNU1 = "CSCDNU1";

        /// <summary>
        /// CSCDNU2.
        /// </summary>
        public const string CSCDNU2 = "CSCDNU2";

        /// <summary>
        /// CSCDNU3.
        /// </summary>
        public const string CSCDNU3 = "CSCDNU3";

        /// <summary>
        /// CSCDST1.
        /// </summary>
        public const string CSCDST1 = "CSCDST1";

        /// <summary>
        /// CSCDST2.
        /// </summary>
        public const string CSCDST2 = "CSCDST2";

        /// <summary>
        /// CSCDST3.
        /// </summary>
        public const string CSCDST3 = "CSCDST3";

        /// <summary>
        /// CSCDCT1.
        /// </summary>
        public const string CSCDCT1 = "CSCDCT1";

        /// <summary>
        /// CSCDCT2.
        /// </summary>
        public const string CSCDCT2 = "CSCDCT2";

        /// <summary>
        /// CSCDCT3.
        /// </summary>
        public const string CSCDCT3 = "CSCDCT3";

        /// <summary>
        /// CSCDDT1.
        /// </summary>
        public const string CSCDDT1 = "CSCDDT1";

        /// <summary>
        /// CSCDDT2.
        /// </summary>
        public const string CSCDDT2 = "CSCDDT2";

        /// <summary>
        /// CSCDDT3.
        /// </summary>
        public const string CSCDDT3 = "CSCDDT3";

        /// <summary>
        /// CSCRTBY.
        /// </summary>
        public const string CSCRTBY = "CSCRTBY";

        /// <summary>
        /// CSUSER.
        /// </summary>
        public const string CSUSER = "CSUSER";

        /// <summary>
        /// CSPID.
        /// </summary>
        public const string CSPID = "CSPID";

        /// <summary>
        /// CSJOBN.
        /// </summary>
        public const string CSJOBN = "CSJOBN";

        /// <summary>
        /// CSUPMJ.
        /// </summary>
        public const string CSUPMJ = "CSUPMJ";

        /// <summary>
        /// CSUPMT.
        /// </summary>
        public const string CSUPMT = "CSUPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F09320";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("CSCSTN", "CSCSTN", JdeDataType.String, 40, true, true),
        new JdeField("CSCSTDC", "CSCSTDC", JdeDataType.String, 160),
        new JdeField("CSFRLT", "CSFRLT", JdeDataType.String, 4),
        new JdeField("CSFYOFF", "CSFYOFF", JdeDataType.Numeric),
        new JdeField("CSPNOFF", "CSPNOFF", JdeDataType.Numeric),
        new JdeField("CSQTOFF", "CSQTOFF", JdeDataType.Numeric),
        new JdeField("CSBLNOP", "CSBLNOP", JdeDataType.String, 4),
        new JdeField("CSCSTIT", "CSCSTIT", JdeDataType.String, 160),
        new JdeField("CSQRYE", "CSQRYE", JdeDataType.String, 2),
        new JdeField("CSSTMSG", "CSSTMSG", JdeDataType.String, 4),
        new JdeField("CSFRCC1", "CSFRCC1", JdeDataType.String, 20),
        new JdeField("CSFRCC2", "CSFRCC2", JdeDataType.String, 20),
        new JdeField("CSFRCC3", "CSFRCC3", JdeDataType.String, 20),
        new JdeField("CSFRCC4", "CSFRCC4", JdeDataType.String, 20),
        new JdeField("CSFRCC5", "CSFRCC5", JdeDataType.String, 20),
        new JdeField("CSWOBNM", "CSWOBNM", JdeDataType.String, 60),
        new JdeField("CSCDNU1", "CSCDNU1", JdeDataType.Numeric),
        new JdeField("CSCDNU2", "CSCDNU2", JdeDataType.Numeric),
        new JdeField("CSCDNU3", "CSCDNU3", JdeDataType.Numeric),
        new JdeField("CSCDST1", "CSCDST1", JdeDataType.String, 160),
        new JdeField("CSCDST2", "CSCDST2", JdeDataType.String, 160),
        new JdeField("CSCDST3", "CSCDST3", JdeDataType.String, 160),
        new JdeField("CSCDCT1", "CSCDCT1", JdeDataType.String, 2),
        new JdeField("CSCDCT2", "CSCDCT2", JdeDataType.String, 2),
        new JdeField("CSCDCT3", "CSCDCT3", JdeDataType.String, 2),
        new JdeField("CSCDDT1", "CSCDDT1", JdeDataType.Numeric),
        new JdeField("CSCDDT2", "CSCDDT2", JdeDataType.Numeric),
        new JdeField("CSCDDT3", "CSCDDT3", JdeDataType.Numeric),
        new JdeField("CSCRTBY", "CSCRTBY", JdeDataType.String, 20),
        new JdeField("CSUSER", "CSUSER", JdeDataType.String, 20),
        new JdeField("CSPID", "CSPID", JdeDataType.String, 20),
        new JdeField("CSJOBN", "CSJOBN", JdeDataType.String, 20),
        new JdeField("CSUPMJ", "CSUPMJ", JdeDataType.Numeric),
        new JdeField("CSUPMT", "CSUPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09320_0", "Primary Key on CSCSTN", new[] { "CSCSTN" }, isUnique: true, isPrimaryKey: true)
    };
}
