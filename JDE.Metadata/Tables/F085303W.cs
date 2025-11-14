using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F085303W - .
/// </summary>
public class F085303W : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// W4AN8.
        /// </summary>
        public const string W4AN8 = "W4AN8";

        /// <summary>
        /// W4MUMJ.
        /// </summary>
        public const string W4MUMJ = "W4MUMJ";

        /// <summary>
        /// W4MUMT.
        /// </summary>
        public const string W4MUMT = "W4MUMT";

        /// <summary>
        /// W4ACFL.
        /// </summary>
        public const string W4ACFL = "W4ACFL";

        /// <summary>
        /// W4CALYEAR.
        /// </summary>
        public const string W4CALYEAR = "W4CALYEAR";

        /// <summary>
        /// W4W4MARST.
        /// </summary>
        public const string W4W4MARST = "W4W4MARST";

        /// <summary>
        /// W4W4NMCHFL.
        /// </summary>
        public const string W4W4NMCHFL = "W4W4NMCHFL";

        /// <summary>
        /// W4W4NOALL.
        /// </summary>
        public const string W4W4NOALL = "W4W4NOALL";

        /// <summary>
        /// W4W4AW.
        /// </summary>
        public const string W4W4AW = "W4W4AW";

        /// <summary>
        /// W4W4EXMFLG.
        /// </summary>
        public const string W4W4EXMFLG = "W4W4EXMFLG";

        /// <summary>
        /// W4COMNT1.
        /// </summary>
        public const string W4COMNT1 = "W4COMNT1";

        /// <summary>
        /// W4COMNT2.
        /// </summary>
        public const string W4COMNT2 = "W4COMNT2";

        /// <summary>
        /// W4APR.
        /// </summary>
        public const string W4APR = "W4APR";

        /// <summary>
        /// W4SINT.
        /// </summary>
        public const string W4SINT = "W4SINT";

        /// <summary>
        /// W4ADAT.
        /// </summary>
        public const string W4ADAT = "W4ADAT";

        /// <summary>
        /// W4W4MLJBFL.
        /// </summary>
        public const string W4W4MLJBFL = "W4W4MLJBFL";

        /// <summary>
        /// W4W4CLMDP1.
        /// </summary>
        public const string W4W4CLMDP1 = "W4W4CLMDP1";

        /// <summary>
        /// W4W4CLMDP2.
        /// </summary>
        public const string W4W4CLMDP2 = "W4W4CLMDP2";

        /// <summary>
        /// W4W4TLCLDP.
        /// </summary>
        public const string W4W4TLCLDP = "W4W4TLCLDP";

        /// <summary>
        /// W4W4OTHINC.
        /// </summary>
        public const string W4W4OTHINC = "W4W4OTHINC";

        /// <summary>
        /// W4W4DEDS.
        /// </summary>
        public const string W4W4DEDS = "W4W4DEDS";

        /// <summary>
        /// W4USER.
        /// </summary>
        public const string W4USER = "W4USER";

        /// <summary>
        /// W4PID.
        /// </summary>
        public const string W4PID = "W4PID";

        /// <summary>
        /// W4JOBN.
        /// </summary>
        public const string W4JOBN = "W4JOBN";

        /// <summary>
        /// W4UPMJ.
        /// </summary>
        public const string W4UPMJ = "W4UPMJ";

        /// <summary>
        /// W4UPMT.
        /// </summary>
        public const string W4UPMT = "W4UPMT";

        /// <summary>
        /// W4ESIGN.
        /// </summary>
        public const string W4ESIGN = "W4ESIGN";

        /// <summary>
        /// W4UPID.
        /// </summary>
        public const string W4UPID = "W4UPID";
    }

    /// <inheritdoc />
    public override string TableName => "F085303W";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("W4AN8", "W4AN8", JdeDataType.Numeric, null, true, true),
        new JdeField("W4MUMJ", "W4MUMJ", JdeDataType.Numeric, null, true, true),
        new JdeField("W4MUMT", "W4MUMT", JdeDataType.Numeric, null, true, true),
        new JdeField("W4ACFL", "W4ACFL", JdeDataType.String, 2),
        new JdeField("W4CALYEAR", "W4CALYEAR", JdeDataType.Numeric),
        new JdeField("W4W4MARST", "W4W4MARST", JdeDataType.String, 2),
        new JdeField("W4W4NMCHFL", "W4W4NMCHFL", JdeDataType.String, 2),
        new JdeField("W4W4NOALL", "W4W4NOALL", JdeDataType.Numeric),
        new JdeField("W4W4AW", "W4W4AW", JdeDataType.Numeric),
        new JdeField("W4W4EXMFLG", "W4W4EXMFLG", JdeDataType.String, 2),
        new JdeField("W4COMNT1", "W4COMNT1", JdeDataType.String, 80),
        new JdeField("W4COMNT2", "W4COMNT2", JdeDataType.String, 80),
        new JdeField("W4APR", "W4APR", JdeDataType.String, 2),
        new JdeField("W4SINT", "W4SINT", JdeDataType.String, 20),
        new JdeField("W4ADAT", "W4ADAT", JdeDataType.Numeric),
        new JdeField("W4W4MLJBFL", "W4W4MLJBFL", JdeDataType.String, 2),
        new JdeField("W4W4CLMDP1", "W4W4CLMDP1", JdeDataType.Numeric),
        new JdeField("W4W4CLMDP2", "W4W4CLMDP2", JdeDataType.Numeric),
        new JdeField("W4W4TLCLDP", "W4W4TLCLDP", JdeDataType.Numeric),
        new JdeField("W4W4OTHINC", "W4W4OTHINC", JdeDataType.Numeric),
        new JdeField("W4W4DEDS", "W4W4DEDS", JdeDataType.Numeric),
        new JdeField("W4USER", "W4USER", JdeDataType.String, 20),
        new JdeField("W4PID", "W4PID", JdeDataType.String, 20),
        new JdeField("W4JOBN", "W4JOBN", JdeDataType.String, 20),
        new JdeField("W4UPMJ", "W4UPMJ", JdeDataType.Numeric),
        new JdeField("W4UPMT", "W4UPMT", JdeDataType.Numeric),
        new JdeField("W4ESIGN", "W4ESIGN", JdeDataType.String, 32),
        new JdeField("W4UPID", "W4UPID", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F085303W_0", "Primary Key on W4AN8, W4MUMJ, W4MUMT", new[] { "W4AN8", "W4MUMJ", "W4MUMT" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F085303W_2", "Index on W4AN8, SYS_NC00029$", new[] { "W4AN8", "SYS_NC00029$" })
    };
}
