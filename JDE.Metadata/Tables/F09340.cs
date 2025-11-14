using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F09340 - .
/// </summary>
public class F09340 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// VSRPSTN.
        /// </summary>
        public const string VSRPSTN = "VSRPSTN";

        /// <summary>
        /// VSVERN.
        /// </summary>
        public const string VSVERN = "VSVERN";

        /// <summary>
        /// VSVERD.
        /// </summary>
        public const string VSVERD = "VSVERD";

        /// <summary>
        /// VSVERPN.
        /// </summary>
        public const string VSVERPN = "VSVERPN";

        /// <summary>
        /// VSVERFY.
        /// </summary>
        public const string VSVERFY = "VSVERFY";

        /// <summary>
        /// VSRPCO.
        /// </summary>
        public const string VSRPCO = "VSRPCO";

        /// <summary>
        /// VSBUDEFT.
        /// </summary>
        public const string VSBUDEFT = "VSBUDEFT";

        /// <summary>
        /// VSSVER.
        /// </summary>
        public const string VSSVER = "VSSVER";

        /// <summary>
        /// VSLDA.
        /// </summary>
        public const string VSLDA = "VSLDA";

        /// <summary>
        /// VSZRSF.
        /// </summary>
        public const string VSZRSF = "VSZRSF";

        /// <summary>
        /// VSSDF.
        /// </summary>
        public const string VSSDF = "VSSDF";

        /// <summary>
        /// VSVSDATE.
        /// </summary>
        public const string VSVSDATE = "VSVSDATE";

        /// <summary>
        /// VSVSTIME.
        /// </summary>
        public const string VSVSTIME = "VSVSTIME";

        /// <summary>
        /// VSLNGP.
        /// </summary>
        public const string VSLNGP = "VSLNGP";

        /// <summary>
        /// VSQRYE.
        /// </summary>
        public const string VSQRYE = "VSQRYE";

        /// <summary>
        /// VSLYNM.
        /// </summary>
        public const string VSLYNM = "VSLYNM";

        /// <summary>
        /// VSLYFM.
        /// </summary>
        public const string VSLYFM = "VSLYFM";

        /// <summary>
        /// VSCLYF.
        /// </summary>
        public const string VSCLYF = "VSCLYF";

        /// <summary>
        /// VSFRCC1.
        /// </summary>
        public const string VSFRCC1 = "VSFRCC1";

        /// <summary>
        /// VSFRCC2.
        /// </summary>
        public const string VSFRCC2 = "VSFRCC2";

        /// <summary>
        /// VSFRCC3.
        /// </summary>
        public const string VSFRCC3 = "VSFRCC3";

        /// <summary>
        /// VSFRCC4.
        /// </summary>
        public const string VSFRCC4 = "VSFRCC4";

        /// <summary>
        /// VSFRCC5.
        /// </summary>
        public const string VSFRCC5 = "VSFRCC5";

        /// <summary>
        /// VSWOBNM.
        /// </summary>
        public const string VSWOBNM = "VSWOBNM";

        /// <summary>
        /// VSVRNU1.
        /// </summary>
        public const string VSVRNU1 = "VSVRNU1";

        /// <summary>
        /// VSVRNU2.
        /// </summary>
        public const string VSVRNU2 = "VSVRNU2";

        /// <summary>
        /// VSVRNU3.
        /// </summary>
        public const string VSVRNU3 = "VSVRNU3";

        /// <summary>
        /// VSVRST1.
        /// </summary>
        public const string VSVRST1 = "VSVRST1";

        /// <summary>
        /// VSVRST2.
        /// </summary>
        public const string VSVRST2 = "VSVRST2";

        /// <summary>
        /// VSVRST3.
        /// </summary>
        public const string VSVRST3 = "VSVRST3";

        /// <summary>
        /// VSVRCT1.
        /// </summary>
        public const string VSVRCT1 = "VSVRCT1";

        /// <summary>
        /// VSVRCT2.
        /// </summary>
        public const string VSVRCT2 = "VSVRCT2";

        /// <summary>
        /// VSVRCT3.
        /// </summary>
        public const string VSVRCT3 = "VSVRCT3";

        /// <summary>
        /// VSVRDT1.
        /// </summary>
        public const string VSVRDT1 = "VSVRDT1";

        /// <summary>
        /// VSVRDT2.
        /// </summary>
        public const string VSVRDT2 = "VSVRDT2";

        /// <summary>
        /// VSVRDT3.
        /// </summary>
        public const string VSVRDT3 = "VSVRDT3";

        /// <summary>
        /// VSCRTBY.
        /// </summary>
        public const string VSCRTBY = "VSCRTBY";

        /// <summary>
        /// VSUSER.
        /// </summary>
        public const string VSUSER = "VSUSER";

        /// <summary>
        /// VSPID.
        /// </summary>
        public const string VSPID = "VSPID";

        /// <summary>
        /// VSJOBN.
        /// </summary>
        public const string VSJOBN = "VSJOBN";

        /// <summary>
        /// VSUPMJ.
        /// </summary>
        public const string VSUPMJ = "VSUPMJ";

        /// <summary>
        /// VSUPMT.
        /// </summary>
        public const string VSUPMT = "VSUPMT";

        /// <summary>
        /// VSBASMCU.
        /// </summary>
        public const string VSBASMCU = "VSBASMCU";

        /// <summary>
        /// VSCNILF.
        /// </summary>
        public const string VSCNILF = "VSCNILF";
    }

    /// <inheritdoc />
    public override string TableName => "F09340";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("VSRPSTN", "VSRPSTN", JdeDataType.String, 40, true, true),
        new JdeField("VSVERN", "VSVERN", JdeDataType.String, 40, true, true),
        new JdeField("VSVERD", "VSVERD", JdeDataType.String, 160),
        new JdeField("VSVERPN", "VSVERPN", JdeDataType.Numeric),
        new JdeField("VSVERFY", "VSVERFY", JdeDataType.Numeric),
        new JdeField("VSRPCO", "VSRPCO", JdeDataType.String, 10),
        new JdeField("VSBUDEFT", "VSBUDEFT", JdeDataType.Numeric),
        new JdeField("VSSVER", "VSSVER", JdeDataType.String, 20),
        new JdeField("VSLDA", "VSLDA", JdeDataType.String, 2),
        new JdeField("VSZRSF", "VSZRSF", JdeDataType.String, 2),
        new JdeField("VSSDF", "VSSDF", JdeDataType.String, 2),
        new JdeField("VSVSDATE", "VSVSDATE", JdeDataType.Numeric),
        new JdeField("VSVSTIME", "VSVSTIME", JdeDataType.Numeric),
        new JdeField("VSLNGP", "VSLNGP", JdeDataType.String, 4),
        new JdeField("VSQRYE", "VSQRYE", JdeDataType.String, 2),
        new JdeField("VSLYNM", "VSLYNM", JdeDataType.String, 200),
        new JdeField("VSLYFM", "VSLYFM", JdeDataType.String, 100),
        new JdeField("VSCLYF", "VSCLYF", JdeDataType.String, 2),
        new JdeField("VSFRCC1", "VSFRCC1", JdeDataType.String, 20),
        new JdeField("VSFRCC2", "VSFRCC2", JdeDataType.String, 20),
        new JdeField("VSFRCC3", "VSFRCC3", JdeDataType.String, 20),
        new JdeField("VSFRCC4", "VSFRCC4", JdeDataType.String, 20),
        new JdeField("VSFRCC5", "VSFRCC5", JdeDataType.String, 20),
        new JdeField("VSWOBNM", "VSWOBNM", JdeDataType.String, 60),
        new JdeField("VSVRNU1", "VSVRNU1", JdeDataType.Numeric),
        new JdeField("VSVRNU2", "VSVRNU2", JdeDataType.Numeric),
        new JdeField("VSVRNU3", "VSVRNU3", JdeDataType.Numeric),
        new JdeField("VSVRST1", "VSVRST1", JdeDataType.String, 160),
        new JdeField("VSVRST2", "VSVRST2", JdeDataType.String, 160),
        new JdeField("VSVRST3", "VSVRST3", JdeDataType.String, 160),
        new JdeField("VSVRCT1", "VSVRCT1", JdeDataType.String, 2),
        new JdeField("VSVRCT2", "VSVRCT2", JdeDataType.String, 2),
        new JdeField("VSVRCT3", "VSVRCT3", JdeDataType.String, 2),
        new JdeField("VSVRDT1", "VSVRDT1", JdeDataType.Numeric),
        new JdeField("VSVRDT2", "VSVRDT2", JdeDataType.Numeric),
        new JdeField("VSVRDT3", "VSVRDT3", JdeDataType.Numeric),
        new JdeField("VSCRTBY", "VSCRTBY", JdeDataType.String, 20),
        new JdeField("VSUSER", "VSUSER", JdeDataType.String, 20),
        new JdeField("VSPID", "VSPID", JdeDataType.String, 20),
        new JdeField("VSJOBN", "VSJOBN", JdeDataType.String, 20),
        new JdeField("VSUPMJ", "VSUPMJ", JdeDataType.Numeric),
        new JdeField("VSUPMT", "VSUPMT", JdeDataType.Numeric),
        new JdeField("VSBASMCU", "VSBASMCU", JdeDataType.String, 24),
        new JdeField("VSCNILF", "VSCNILF", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F09340_0", "Primary Key on VSRPSTN, VSVERN", new[] { "VSRPSTN", "VSVERN" }, isUnique: true, isPrimaryKey: true)
    };
}
