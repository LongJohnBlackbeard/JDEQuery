using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F75I808 - .
/// </summary>
public class F75I808 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// RTMATC.
        /// </summary>
        public const string RTMATC = "RTMATC";

        /// <summary>
        /// RTDOCO.
        /// </summary>
        public const string RTDOCO = "RTDOCO";

        /// <summary>
        /// RTDCTO.
        /// </summary>
        public const string RTDCTO = "RTDCTO";

        /// <summary>
        /// RTKCOO.
        /// </summary>
        public const string RTKCOO = "RTKCOO";

        /// <summary>
        /// RTLNID.
        /// </summary>
        public const string RTLNID = "RTLNID";

        /// <summary>
        /// RTNLIN.
        /// </summary>
        public const string RTNLIN = "RTNLIN";

        /// <summary>
        /// RTSFXO.
        /// </summary>
        public const string RTSFXO = "RTSFXO";

        /// <summary>
        /// RTLVLA.
        /// </summary>
        public const string RTLVLA = "RTLVLA";

        /// <summary>
        /// RTUORGE1.
        /// </summary>
        public const string RTUORGE1 = "RTUORGE1";

        /// <summary>
        /// RTUPAX.
        /// </summary>
        public const string RTUPAX = "RTUPAX";

        /// <summary>
        /// RTAEXPE1.
        /// </summary>
        public const string RTAEXPE1 = "RTAEXPE1";

        /// <summary>
        /// RTI75PSP.
        /// </summary>
        public const string RTI75PSP = "RTI75PSP";

        /// <summary>
        /// RTI75PSR.
        /// </summary>
        public const string RTI75PSR = "RTI75PSR";

        /// <summary>
        /// RTI75PROVL.
        /// </summary>
        public const string RTI75PROVL = "RTI75PROVL";

        /// <summary>
        /// RTI75RECVL.
        /// </summary>
        public const string RTI75RECVL = "RTI75RECVL";

        /// <summary>
        /// RTJOBS.
        /// </summary>
        public const string RTJOBS = "RTJOBS";

        /// <summary>
        /// RTUSER.
        /// </summary>
        public const string RTUSER = "RTUSER";

        /// <summary>
        /// RTPID.
        /// </summary>
        public const string RTPID = "RTPID";

        /// <summary>
        /// RTJOBN.
        /// </summary>
        public const string RTJOBN = "RTJOBN";

        /// <summary>
        /// RTUPMJ.
        /// </summary>
        public const string RTUPMJ = "RTUPMJ";

        /// <summary>
        /// RTUPMT.
        /// </summary>
        public const string RTUPMT = "RTUPMT";

        /// <summary>
        /// RTDATF01.
        /// </summary>
        public const string RTDATF01 = "RTDATF01";

        /// <summary>
        /// RTDEPFUT2.
        /// </summary>
        public const string RTDEPFUT2 = "RTDEPFUT2";

        /// <summary>
        /// RTACTFU1.
        /// </summary>
        public const string RTACTFU1 = "RTACTFU1";

        /// <summary>
        /// RTFLAG.
        /// </summary>
        public const string RTFLAG = "RTFLAG";
    }

    /// <inheritdoc />
    public override string TableName => "F75I808";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("RTMATC", "RTMATC", JdeDataType.String, 2, true, true),
        new JdeField("RTDOCO", "RTDOCO", JdeDataType.Numeric, null, true, true),
        new JdeField("RTDCTO", "RTDCTO", JdeDataType.String, 4, true, true),
        new JdeField("RTKCOO", "RTKCOO", JdeDataType.String, 10, true, true),
        new JdeField("RTLNID", "RTLNID", JdeDataType.Numeric, null, true, true),
        new JdeField("RTNLIN", "RTNLIN", JdeDataType.Numeric, null, true, true),
        new JdeField("RTSFXO", "RTSFXO", JdeDataType.String, 6, true, true),
        new JdeField("RTLVLA", "RTLVLA", JdeDataType.String, 6),
        new JdeField("RTUORGE1", "RTUORGE1", JdeDataType.Numeric),
        new JdeField("RTUPAX", "RTUPAX", JdeDataType.Numeric),
        new JdeField("RTAEXPE1", "RTAEXPE1", JdeDataType.Numeric),
        new JdeField("RTI75PSP", "RTI75PSP", JdeDataType.Numeric),
        new JdeField("RTI75PSR", "RTI75PSR", JdeDataType.Numeric),
        new JdeField("RTI75PROVL", "RTI75PROVL", JdeDataType.Numeric),
        new JdeField("RTI75RECVL", "RTI75RECVL", JdeDataType.Numeric),
        new JdeField("RTJOBS", "RTJOBS", JdeDataType.Numeric),
        new JdeField("RTUSER", "RTUSER", JdeDataType.String, 20),
        new JdeField("RTPID", "RTPID", JdeDataType.String, 20),
        new JdeField("RTJOBN", "RTJOBN", JdeDataType.String, 20),
        new JdeField("RTUPMJ", "RTUPMJ", JdeDataType.Numeric),
        new JdeField("RTUPMT", "RTUPMT", JdeDataType.Numeric),
        new JdeField("RTDATF01", "RTDATF01", JdeDataType.Numeric),
        new JdeField("RTDEPFUT2", "RTDEPFUT2", JdeDataType.String, 60),
        new JdeField("RTACTFU1", "RTACTFU1", JdeDataType.String, 2),
        new JdeField("RTFLAG", "RTFLAG", JdeDataType.String, 2)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F75I808_0", "Primary Key on RTMATC, RTDOCO, RTDCTO, RTKCOO, RTLNID, RTNLIN, RTSFXO", new[] { "RTMATC", "RTDOCO", "RTDCTO", "RTKCOO", "RTLNID", "RTNLIN", "RTSFXO" }, isUnique: true, isPrimaryKey: true)
    };
}
