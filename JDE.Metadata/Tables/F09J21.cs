using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09J21 - .
/// </summary>
public class F09J21 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// JCJVDOI.
        /// </summary>
        public const string JCJVDOI = "JCJVDOI";

        /// <summary>
        /// JCEFTB.
        /// </summary>
        public const string JCEFTB = "JCEFTB";

        /// <summary>
        /// JCAN8.
        /// </summary>
        public const string JCAN8 = "JCAN8";

        /// <summary>
        /// JCJVPOI.
        /// </summary>
        public const string JCJVPOI = "JCJVPOI";

        /// <summary>
        /// JCJVET.
        /// </summary>
        public const string JCJVET = "JCJVET";

        /// <summary>
        /// JCJVDIS.
        /// </summary>
        public const string JCJVDIS = "JCJVDIS";

        /// <summary>
        /// JCJVDDA.
        /// </summary>
        public const string JCJVDDA = "JCJVDDA";

        /// <summary>
        /// JCUSER.
        /// </summary>
        public const string JCUSER = "JCUSER";

        /// <summary>
        /// JCUPMJ.
        /// </summary>
        public const string JCUPMJ = "JCUPMJ";

        /// <summary>
        /// JCUPMT.
        /// </summary>
        public const string JCUPMT = "JCUPMT";

        /// <summary>
        /// JCPID.
        /// </summary>
        public const string JCPID = "JCPID";

        /// <summary>
        /// JCMKEY.
        /// </summary>
        public const string JCMKEY = "JCMKEY";

        /// <summary>
        /// JCURAB.
        /// </summary>
        public const string JCURAB = "JCURAB";

        /// <summary>
        /// JCURCD.
        /// </summary>
        public const string JCURCD = "JCURCD";

        /// <summary>
        /// JCURAT.
        /// </summary>
        public const string JCURAT = "JCURAT";

        /// <summary>
        /// JCURDT.
        /// </summary>
        public const string JCURDT = "JCURDT";

        /// <summary>
        /// JCURRF.
        /// </summary>
        public const string JCURRF = "JCURRF";

        /// <summary>
        /// JCJVDNU1.
        /// </summary>
        public const string JCJVDNU1 = "JCJVDNU1";

        /// <summary>
        /// JCJVDNU2.
        /// </summary>
        public const string JCJVDNU2 = "JCJVDNU2";

        /// <summary>
        /// JCJVDNU3.
        /// </summary>
        public const string JCJVDNU3 = "JCJVDNU3";

        /// <summary>
        /// JCJVDST1.
        /// </summary>
        public const string JCJVDST1 = "JCJVDST1";

        /// <summary>
        /// JCJVDST2.
        /// </summary>
        public const string JCJVDST2 = "JCJVDST2";

        /// <summary>
        /// JCJVDST3.
        /// </summary>
        public const string JCJVDST3 = "JCJVDST3";

        /// <summary>
        /// JCJVDCH1.
        /// </summary>
        public const string JCJVDCH1 = "JCJVDCH1";

        /// <summary>
        /// JCJVDCH2.
        /// </summary>
        public const string JCJVDCH2 = "JCJVDCH2";

        /// <summary>
        /// JCJVDCH3.
        /// </summary>
        public const string JCJVDCH3 = "JCJVDCH3";

        /// <summary>
        /// JCJVDDT1.
        /// </summary>
        public const string JCJVDDT1 = "JCJVDDT1";

        /// <summary>
        /// JCJVDDT2.
        /// </summary>
        public const string JCJVDDT2 = "JCJVDDT2";

        /// <summary>
        /// JCJVDDT3.
        /// </summary>
        public const string JCJVDDT3 = "JCJVDDT3";

        /// <summary>
        /// JCJVIBU.
        /// </summary>
        public const string JCJVIBU = "JCJVIBU";

        /// <summary>
        /// JCJVRNDP.
        /// </summary>
        public const string JCJVRNDP = "JCJVRNDP";

        /// <summary>
        /// JCJVIVI.
        /// </summary>
        public const string JCJVIVI = "JCJVIVI";
    }

    /// <inheritdoc />
    public override string TableName => "F09J21";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("JCJVDOI", "JCJVDOI", JdeDataType.String, 40, true, true),
        new JdeField("JCEFTB", "JCEFTB", JdeDataType.Numeric, null, true, true),
        new JdeField("JCAN8", "JCAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("JCJVPOI", "JCJVPOI", JdeDataType.Numeric),
        new JdeField("JCJVET", "JCJVET", JdeDataType.String, 6),
        new JdeField("JCJVDIS", "JCJVDIS", JdeDataType.String, 2),
        new JdeField("JCJVDDA", "JCJVDDA", JdeDataType.Numeric),
        new JdeField("JCUSER", "JCUSER", JdeDataType.String, 20),
        new JdeField("JCUPMJ", "JCUPMJ", JdeDataType.Numeric),
        new JdeField("JCUPMT", "JCUPMT", JdeDataType.Numeric),
        new JdeField("JCPID", "JCPID", JdeDataType.String, 20),
        new JdeField("JCMKEY", "JCMKEY", JdeDataType.String, 30),
        new JdeField("JCURAB", "JCURAB", JdeDataType.Numeric),
        new JdeField("JCURCD", "JCURCD", JdeDataType.String, 4),
        new JdeField("JCURAT", "JCURAT", JdeDataType.Numeric),
        new JdeField("JCURDT", "JCURDT", JdeDataType.Numeric),
        new JdeField("JCURRF", "JCURRF", JdeDataType.String, 30),
        new JdeField("JCJVDNU1", "JCJVDNU1", JdeDataType.Numeric),
        new JdeField("JCJVDNU2", "JCJVDNU2", JdeDataType.Numeric),
        new JdeField("JCJVDNU3", "JCJVDNU3", JdeDataType.Numeric),
        new JdeField("JCJVDST1", "JCJVDST1", JdeDataType.String, 160),
        new JdeField("JCJVDST2", "JCJVDST2", JdeDataType.String, 160),
        new JdeField("JCJVDST3", "JCJVDST3", JdeDataType.String, 160),
        new JdeField("JCJVDCH1", "JCJVDCH1", JdeDataType.String, 2),
        new JdeField("JCJVDCH2", "JCJVDCH2", JdeDataType.String, 2),
        new JdeField("JCJVDCH3", "JCJVDCH3", JdeDataType.String, 2),
        new JdeField("JCJVDDT1", "JCJVDDT1", JdeDataType.Numeric),
        new JdeField("JCJVDDT2", "JCJVDDT2", JdeDataType.Numeric),
        new JdeField("JCJVDDT3", "JCJVDDT3", JdeDataType.Numeric),
        new JdeField("JCJVIBU", "JCJVIBU", JdeDataType.String, 24, true, true),
        new JdeField("JCJVRNDP", "JCJVRNDP", JdeDataType.String, 2),
        new JdeField("JCJVIVI", "JCJVIVI", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09J21_0", "Primary Key on JCJVDOI, JCEFTB, JCJVIBU, JCAN8", new[] { "JCJVDOI", "JCEFTB", "JCJVIBU", "JCAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F09J21_2", "Index on JCJVDOI, JCJVDDA", new[] { "JCJVDOI", "JCJVDDA" }),
        new JdeIndex("F09J21_3", "Index on JCJVDOI, SYS_NC00033$, JCJVRNDP, JCJVIBU, JCAN8", new[] { "JCJVDOI", "SYS_NC00033$", "JCJVRNDP", "JCJVIBU", "JCAN8" })
    };
}
