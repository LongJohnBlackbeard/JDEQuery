using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F08201 - .
/// </summary>
public class F08201 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// HRRVW.
        /// </summary>
        public const string HRRVW = "HRRVW";

        /// <summary>
        /// HRDL01.
        /// </summary>
        public const string HRDL01 = "HRDL01";

        /// <summary>
        /// HRSSN.
        /// </summary>
        public const string HRSSN = "HRSSN";

        /// <summary>
        /// HRAN8.
        /// </summary>
        public const string HRAN8 = "HRAN8";

        /// <summary>
        /// HRALPH.
        /// </summary>
        public const string HRALPH = "HRALPH";

        /// <summary>
        /// HRHMCO.
        /// </summary>
        public const string HRHMCO = "HRHMCO";

        /// <summary>
        /// HRHMCU.
        /// </summary>
        public const string HRHMCU = "HRHMCU";

        /// <summary>
        /// HRANPA.
        /// </summary>
        public const string HRANPA = "HRANPA";

        /// <summary>
        /// HRSALY.
        /// </summary>
        public const string HRSALY = "HRSALY";

        /// <summary>
        /// HRPGRD.
        /// </summary>
        public const string HRPGRD = "HRPGRD";

        /// <summary>
        /// HRPGRS.
        /// </summary>
        public const string HRPGRS = "HRPGRS";

        /// <summary>
        /// HRPSTP.
        /// </summary>
        public const string HRPSTP = "HRPSTP";

        /// <summary>
        /// HRPAST.
        /// </summary>
        public const string HRPAST = "HRPAST";

        /// <summary>
        /// HREST.
        /// </summary>
        public const string HREST = "HREST";

        /// <summary>
        /// HRJBCD.
        /// </summary>
        public const string HRJBCD = "HRJBCD";

        /// <summary>
        /// HRJBST.
        /// </summary>
        public const string HRJBST = "HRJBST";

        /// <summary>
        /// HRSLOC.
        /// </summary>
        public const string HRSLOC = "HRSLOC";

        /// <summary>
        /// HRUN.
        /// </summary>
        public const string HRUN = "HRUN";

        /// <summary>
        /// HRPNTS.
        /// </summary>
        public const string HRPNTS = "HRPNTS";

        /// <summary>
        /// HRAPPR.
        /// </summary>
        public const string HRAPPR = "HRAPPR";

        /// <summary>
        /// HRAPTY.
        /// </summary>
        public const string HRAPTY = "HRAPTY";

        /// <summary>
        /// HRDTEA.
        /// </summary>
        public const string HRDTEA = "HRDTEA";

        /// <summary>
        /// HRARMK.
        /// </summary>
        public const string HRARMK = "HRARMK";

        /// <summary>
        /// HRSAL.
        /// </summary>
        public const string HRSAL = "HRSAL";

        /// <summary>
        /// HRPHRT.
        /// </summary>
        public const string HRPHRT = "HRPHRT";

        /// <summary>
        /// HRAYTD.
        /// </summary>
        public const string HRAYTD = "HRAYTD";

        /// <summary>
        /// HRSALN.
        /// </summary>
        public const string HRSALN = "HRSALN";

        /// <summary>
        /// HRHRTN.
        /// </summary>
        public const string HRHRTN = "HRHRTN";

        /// <summary>
        /// HRSALC.
        /// </summary>
        public const string HRSALC = "HRSALC";

        /// <summary>
        /// HRHRTC.
        /// </summary>
        public const string HRHRTC = "HRHRTC";

        /// <summary>
        /// HRAAPR.
        /// </summary>
        public const string HRAAPR = "HRAAPR";

        /// <summary>
        /// HRTRS.
        /// </summary>
        public const string HRTRS = "HRTRS";

        /// <summary>
        /// HRIH.
        /// </summary>
        public const string HRIH = "HRIH";

        /// <summary>
        /// HRAMT1.
        /// </summary>
        public const string HRAMT1 = "HRAMT1";

        /// <summary>
        /// HRAMT2.
        /// </summary>
        public const string HRAMT2 = "HRAMT2";

        /// <summary>
        /// HRAMT3.
        /// </summary>
        public const string HRAMT3 = "HRAMT3";

        /// <summary>
        /// HRAMT4.
        /// </summary>
        public const string HRAMT4 = "HRAMT4";

        /// <summary>
        /// HRAMT5.
        /// </summary>
        public const string HRAMT5 = "HRAMT5";

        /// <summary>
        /// HRAMT6.
        /// </summary>
        public const string HRAMT6 = "HRAMT6";

        /// <summary>
        /// HRAMT7.
        /// </summary>
        public const string HRAMT7 = "HRAMT7";

        /// <summary>
        /// HRAMT8.
        /// </summary>
        public const string HRAMT8 = "HRAMT8";

        /// <summary>
        /// HRAMT9.
        /// </summary>
        public const string HRAMT9 = "HRAMT9";

        /// <summary>
        /// HRAMT0.
        /// </summary>
        public const string HRAMT0 = "HRAMT0";

        /// <summary>
        /// HRBSDT.
        /// </summary>
        public const string HRBSDT = "HRBSDT";

        /// <summary>
        /// HRBNUS.
        /// </summary>
        public const string HRBNUS = "HRBNUS";

        /// <summary>
        /// HRRMK.
        /// </summary>
        public const string HRRMK = "HRRMK";

        /// <summary>
        /// HRDST.
        /// </summary>
        public const string HRDST = "HRDST";

        /// <summary>
        /// HRDSI.
        /// </summary>
        public const string HRDSI = "HRDSI";

        /// <summary>
        /// HRNRDT.
        /// </summary>
        public const string HRNRDT = "HRNRDT";

        /// <summary>
        /// HRNRVW.
        /// </summary>
        public const string HRNRVW = "HRNRVW";

        /// <summary>
        /// HRTINC.
        /// </summary>
        public const string HRTINC = "HRTINC";

        /// <summary>
        /// HRUSER.
        /// </summary>
        public const string HRUSER = "HRUSER";

        /// <summary>
        /// HRPID.
        /// </summary>
        public const string HRPID = "HRPID";

        /// <summary>
        /// HRUPMJ.
        /// </summary>
        public const string HRUPMJ = "HRUPMJ";

        /// <summary>
        /// HRJOBN.
        /// </summary>
        public const string HRJOBN = "HRJOBN";

        /// <summary>
        /// HRBRMK.
        /// </summary>
        public const string HRBRMK = "HRBRMK";
    }

    /// <inheritdoc />
    public override string TableName => "F08201";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("HRRVW", "HRRVW", JdeDataType.String, 12, true, true),
        new JdeField("HRDL01", "HRDL01", JdeDataType.String, 60),
        new JdeField("HRSSN", "HRSSN", JdeDataType.String, 40),
        new JdeField("HRAN8", "HRAN8", JdeDataType.Numeric, null, true, true),
        new JdeField("HRALPH", "HRALPH", JdeDataType.String, 80, true, true),
        new JdeField("HRHMCO", "HRHMCO", JdeDataType.String, 10),
        new JdeField("HRHMCU", "HRHMCU", JdeDataType.String, 24),
        new JdeField("HRANPA", "HRANPA", JdeDataType.Numeric),
        new JdeField("HRSALY", "HRSALY", JdeDataType.String, 2),
        new JdeField("HRPGRD", "HRPGRD", JdeDataType.String, 12),
        new JdeField("HRPGRS", "HRPGRS", JdeDataType.String, 8),
        new JdeField("HRPSTP", "HRPSTP", JdeDataType.String, 8),
        new JdeField("HRPAST", "HRPAST", JdeDataType.String, 2),
        new JdeField("HREST", "HREST", JdeDataType.String, 2),
        new JdeField("HRJBCD", "HRJBCD", JdeDataType.String, 12),
        new JdeField("HRJBST", "HRJBST", JdeDataType.String, 8),
        new JdeField("HRSLOC", "HRSLOC", JdeDataType.String, 16),
        new JdeField("HRUN", "HRUN", JdeDataType.String, 12),
        new JdeField("HRPNTS", "HRPNTS", JdeDataType.Numeric),
        new JdeField("HRAPPR", "HRAPPR", JdeDataType.String, 4),
        new JdeField("HRAPTY", "HRAPTY", JdeDataType.String, 4),
        new JdeField("HRDTEA", "HRDTEA", JdeDataType.Numeric),
        new JdeField("HRARMK", "HRARMK", JdeDataType.String, 60),
        new JdeField("HRSAL", "HRSAL", JdeDataType.Numeric),
        new JdeField("HRPHRT", "HRPHRT", JdeDataType.Numeric),
        new JdeField("HRAYTD", "HRAYTD", JdeDataType.Numeric),
        new JdeField("HRSALN", "HRSALN", JdeDataType.Numeric),
        new JdeField("HRHRTN", "HRHRTN", JdeDataType.Numeric),
        new JdeField("HRSALC", "HRSALC", JdeDataType.Numeric),
        new JdeField("HRHRTC", "HRHRTC", JdeDataType.Numeric),
        new JdeField("HRAAPR", "HRAAPR", JdeDataType.String, 2),
        new JdeField("HRTRS", "HRTRS", JdeDataType.String, 6),
        new JdeField("HRIH", "HRIH", JdeDataType.Numeric),
        new JdeField("HRAMT1", "HRAMT1", JdeDataType.Numeric),
        new JdeField("HRAMT2", "HRAMT2", JdeDataType.Numeric),
        new JdeField("HRAMT3", "HRAMT3", JdeDataType.Numeric),
        new JdeField("HRAMT4", "HRAMT4", JdeDataType.Numeric),
        new JdeField("HRAMT5", "HRAMT5", JdeDataType.Numeric),
        new JdeField("HRAMT6", "HRAMT6", JdeDataType.Numeric),
        new JdeField("HRAMT7", "HRAMT7", JdeDataType.Numeric),
        new JdeField("HRAMT8", "HRAMT8", JdeDataType.Numeric),
        new JdeField("HRAMT9", "HRAMT9", JdeDataType.Numeric),
        new JdeField("HRAMT0", "HRAMT0", JdeDataType.Numeric),
        new JdeField("HRBSDT", "HRBSDT", JdeDataType.Numeric),
        new JdeField("HRBNUS", "HRBNUS", JdeDataType.String, 4),
        new JdeField("HRRMK", "HRRMK", JdeDataType.String, 60),
        new JdeField("HRDST", "HRDST", JdeDataType.Numeric),
        new JdeField("HRDSI", "HRDSI", JdeDataType.Numeric),
        new JdeField("HRNRDT", "HRNRDT", JdeDataType.Numeric),
        new JdeField("HRNRVW", "HRNRVW", JdeDataType.Numeric),
        new JdeField("HRTINC", "HRTINC", JdeDataType.String, 2),
        new JdeField("HRUSER", "HRUSER", JdeDataType.String, 20),
        new JdeField("HRPID", "HRPID", JdeDataType.String, 20),
        new JdeField("HRUPMJ", "HRUPMJ", JdeDataType.Numeric),
        new JdeField("HRJOBN", "HRJOBN", JdeDataType.String, 20),
        new JdeField("HRBRMK", "HRBRMK", JdeDataType.String, 60)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F08201_0", "Primary Key on HRRVW, HRALPH, HRAN8", new[] { "HRRVW", "HRALPH", "HRAN8" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F08201_3", "Index on HRRVW, HRHMCU, HRJBCD, SYS_NC00057$, SYS_NC00058$, HRALPH", new[] { "HRRVW", "HRHMCU", "HRJBCD", "SYS_NC00057$", "SYS_NC00058$", "HRALPH" }),
        new JdeIndex("F08201_4", "Index on HRRVW, HRJBCD, SYS_NC00057$, SYS_NC00058$, HRALPH", new[] { "HRRVW", "HRJBCD", "SYS_NC00057$", "SYS_NC00058$", "HRALPH" }),
        new JdeIndex("F08201_5", "Index on HRRVW, HRANPA, HRJBCD, SYS_NC00057$, SYS_NC00058$, HRALPH", new[] { "HRRVW", "HRANPA", "HRJBCD", "SYS_NC00057$", "SYS_NC00058$", "HRALPH" }),
        new JdeIndex("F08201_6", "Index on HRAN8", new[] { "HRAN8" }),
        new JdeIndex("F08201_7", "Index on HRRVW, HRUN", new[] { "HRRVW", "HRUN" }),
        new JdeIndex("F08201_8", "Index on HRRVW, HRSLOC", new[] { "HRRVW", "HRSLOC" })
    };
}
