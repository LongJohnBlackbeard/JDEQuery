using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F470462 - .
/// </summary>
public class F470462 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// S5EDTY.
        /// </summary>
        public const string S5EDTY = "S5EDTY";

        /// <summary>
        /// S5EDSQ.
        /// </summary>
        public const string S5EDSQ = "S5EDSQ";

        /// <summary>
        /// S5EKCO.
        /// </summary>
        public const string S5EKCO = "S5EKCO";

        /// <summary>
        /// S5EDOC.
        /// </summary>
        public const string S5EDOC = "S5EDOC";

        /// <summary>
        /// S5EDCT.
        /// </summary>
        public const string S5EDCT = "S5EDCT";

        /// <summary>
        /// S5EDSP.
        /// </summary>
        public const string S5EDSP = "S5EDSP";

        /// <summary>
        /// S5EDBT.
        /// </summary>
        public const string S5EDBT = "S5EDBT";

        /// <summary>
        /// S5AN8.
        /// </summary>
        public const string S5AN8 = "S5AN8";

        /// <summary>
        /// S5ALPH.
        /// </summary>
        public const string S5ALPH = "S5ALPH";

        /// <summary>
        /// S5AN81.
        /// </summary>
        public const string S5AN81 = "S5AN81";

        /// <summary>
        /// S5PRTY1.
        /// </summary>
        public const string S5PRTY1 = "S5PRTY1";

        /// <summary>
        /// S5PRTY2.
        /// </summary>
        public const string S5PRTY2 = "S5PRTY2";

        /// <summary>
        /// S5PRTY3.
        /// </summary>
        public const string S5PRTY3 = "S5PRTY3";

        /// <summary>
        /// S5PRTY4.
        /// </summary>
        public const string S5PRTY4 = "S5PRTY4";

        /// <summary>
        /// S5PRTY5.
        /// </summary>
        public const string S5PRTY5 = "S5PRTY5";

        /// <summary>
        /// S5PRNA1.
        /// </summary>
        public const string S5PRNA1 = "S5PRNA1";

        /// <summary>
        /// S5PRNA2.
        /// </summary>
        public const string S5PRNA2 = "S5PRNA2";

        /// <summary>
        /// S5PRNA3.
        /// </summary>
        public const string S5PRNA3 = "S5PRNA3";

        /// <summary>
        /// S5PRNA4.
        /// </summary>
        public const string S5PRNA4 = "S5PRNA4";

        /// <summary>
        /// S5PRNA5.
        /// </summary>
        public const string S5PRNA5 = "S5PRNA5";

        /// <summary>
        /// S5IDTYP1.
        /// </summary>
        public const string S5IDTYP1 = "S5IDTYP1";

        /// <summary>
        /// S5IDTYP2.
        /// </summary>
        public const string S5IDTYP2 = "S5IDTYP2";

        /// <summary>
        /// S5IDTYP3.
        /// </summary>
        public const string S5IDTYP3 = "S5IDTYP3";

        /// <summary>
        /// S5IDTYP4.
        /// </summary>
        public const string S5IDTYP4 = "S5IDTYP4";

        /// <summary>
        /// S5IDTYP5.
        /// </summary>
        public const string S5IDTYP5 = "S5IDTYP5";

        /// <summary>
        /// S5IDNUM1.
        /// </summary>
        public const string S5IDNUM1 = "S5IDNUM1";

        /// <summary>
        /// S5IDNUM2.
        /// </summary>
        public const string S5IDNUM2 = "S5IDNUM2";

        /// <summary>
        /// S5IDNUM3.
        /// </summary>
        public const string S5IDNUM3 = "S5IDNUM3";

        /// <summary>
        /// S5IDNUM4.
        /// </summary>
        public const string S5IDNUM4 = "S5IDNUM4";

        /// <summary>
        /// S5IDNUM5.
        /// </summary>
        public const string S5IDNUM5 = "S5IDNUM5";

        /// <summary>
        /// S5RFTY1.
        /// </summary>
        public const string S5RFTY1 = "S5RFTY1";

        /// <summary>
        /// S5RFTY2.
        /// </summary>
        public const string S5RFTY2 = "S5RFTY2";

        /// <summary>
        /// S5RFTY3.
        /// </summary>
        public const string S5RFTY3 = "S5RFTY3";

        /// <summary>
        /// S5RFTY4.
        /// </summary>
        public const string S5RFTY4 = "S5RFTY4";

        /// <summary>
        /// S5RFTY5.
        /// </summary>
        public const string S5RFTY5 = "S5RFTY5";

        /// <summary>
        /// S5RFNUM1.
        /// </summary>
        public const string S5RFNUM1 = "S5RFNUM1";

        /// <summary>
        /// S5RFNUM2.
        /// </summary>
        public const string S5RFNUM2 = "S5RFNUM2";

        /// <summary>
        /// S5RFNUM3.
        /// </summary>
        public const string S5RFNUM3 = "S5RFNUM3";

        /// <summary>
        /// S5RFNUM4.
        /// </summary>
        public const string S5RFNUM4 = "S5RFNUM4";

        /// <summary>
        /// S5RFNUM5.
        /// </summary>
        public const string S5RFNUM5 = "S5RFNUM5";

        /// <summary>
        /// S5FUT1.
        /// </summary>
        public const string S5FUT1 = "S5FUT1";

        /// <summary>
        /// S5FUT2.
        /// </summary>
        public const string S5FUT2 = "S5FUT2";

        /// <summary>
        /// S5FUT4.
        /// </summary>
        public const string S5FUT4 = "S5FUT4";

        /// <summary>
        /// S5FUT5.
        /// </summary>
        public const string S5FUT5 = "S5FUT5";

        /// <summary>
        /// S5X1.
        /// </summary>
        public const string S5X1 = "S5X1";

        /// <summary>
        /// S5X2.
        /// </summary>
        public const string S5X2 = "S5X2";

        /// <summary>
        /// S5D1FU.
        /// </summary>
        public const string S5D1FU = "S5D1FU";

        /// <summary>
        /// S5D2FU.
        /// </summary>
        public const string S5D2FU = "S5D2FU";

        /// <summary>
        /// S5TORG.
        /// </summary>
        public const string S5TORG = "S5TORG";

        /// <summary>
        /// S5USER.
        /// </summary>
        public const string S5USER = "S5USER";

        /// <summary>
        /// S5PID.
        /// </summary>
        public const string S5PID = "S5PID";

        /// <summary>
        /// S5JOBN.
        /// </summary>
        public const string S5JOBN = "S5JOBN";

        /// <summary>
        /// S5UPMJ.
        /// </summary>
        public const string S5UPMJ = "S5UPMJ";

        /// <summary>
        /// S5UPMT.
        /// </summary>
        public const string S5UPMT = "S5UPMT";

        /// <summary>
        /// S5GAN8.
        /// </summary>
        public const string S5GAN8 = "S5GAN8";

        /// <summary>
        /// S5GANS8.
        /// </summary>
        public const string S5GANS8 = "S5GANS8";
    }

    /// <inheritdoc />
    public override string TableName => "F470462";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("S5EDTY", "S5EDTY", JdeDataType.String, 2),
        new JdeField("S5EDSQ", "S5EDSQ", JdeDataType.Numeric),
        new JdeField("S5EKCO", "S5EKCO", JdeDataType.String, 10, true, true),
        new JdeField("S5EDOC", "S5EDOC", JdeDataType.Numeric, null, true, true),
        new JdeField("S5EDCT", "S5EDCT", JdeDataType.String, 4, true, true),
        new JdeField("S5EDSP", "S5EDSP", JdeDataType.String, 2),
        new JdeField("S5EDBT", "S5EDBT", JdeDataType.String, 30),
        new JdeField("S5AN8", "S5AN8", JdeDataType.Numeric),
        new JdeField("S5ALPH", "S5ALPH", JdeDataType.String, 80),
        new JdeField("S5AN81", "S5AN81", JdeDataType.Numeric),
        new JdeField("S5PRTY1", "S5PRTY1", JdeDataType.String, 4),
        new JdeField("S5PRTY2", "S5PRTY2", JdeDataType.String, 4),
        new JdeField("S5PRTY3", "S5PRTY3", JdeDataType.String, 4),
        new JdeField("S5PRTY4", "S5PRTY4", JdeDataType.String, 4),
        new JdeField("S5PRTY5", "S5PRTY5", JdeDataType.String, 4),
        new JdeField("S5PRNA1", "S5PRNA1", JdeDataType.String, 70),
        new JdeField("S5PRNA2", "S5PRNA2", JdeDataType.String, 70),
        new JdeField("S5PRNA3", "S5PRNA3", JdeDataType.String, 70),
        new JdeField("S5PRNA4", "S5PRNA4", JdeDataType.String, 70),
        new JdeField("S5PRNA5", "S5PRNA5", JdeDataType.String, 70),
        new JdeField("S5IDTYP1", "S5IDTYP1", JdeDataType.String, 4),
        new JdeField("S5IDTYP2", "S5IDTYP2", JdeDataType.String, 4),
        new JdeField("S5IDTYP3", "S5IDTYP3", JdeDataType.String, 4),
        new JdeField("S5IDTYP4", "S5IDTYP4", JdeDataType.String, 4),
        new JdeField("S5IDTYP5", "S5IDTYP5", JdeDataType.String, 4),
        new JdeField("S5IDNUM1", "S5IDNUM1", JdeDataType.String, 40),
        new JdeField("S5IDNUM2", "S5IDNUM2", JdeDataType.String, 40),
        new JdeField("S5IDNUM3", "S5IDNUM3", JdeDataType.String, 40),
        new JdeField("S5IDNUM4", "S5IDNUM4", JdeDataType.String, 40),
        new JdeField("S5IDNUM5", "S5IDNUM5", JdeDataType.String, 40),
        new JdeField("S5RFTY1", "S5RFTY1", JdeDataType.String, 6),
        new JdeField("S5RFTY2", "S5RFTY2", JdeDataType.String, 6),
        new JdeField("S5RFTY3", "S5RFTY3", JdeDataType.String, 6),
        new JdeField("S5RFTY4", "S5RFTY4", JdeDataType.String, 6),
        new JdeField("S5RFTY5", "S5RFTY5", JdeDataType.String, 6),
        new JdeField("S5RFNUM1", "S5RFNUM1", JdeDataType.String, 60),
        new JdeField("S5RFNUM2", "S5RFNUM2", JdeDataType.String, 60),
        new JdeField("S5RFNUM3", "S5RFNUM3", JdeDataType.String, 60),
        new JdeField("S5RFNUM4", "S5RFNUM4", JdeDataType.String, 60),
        new JdeField("S5RFNUM5", "S5RFNUM5", JdeDataType.String, 60),
        new JdeField("S5FUT1", "S5FUT1", JdeDataType.Numeric),
        new JdeField("S5FUT2", "S5FUT2", JdeDataType.Numeric),
        new JdeField("S5FUT4", "S5FUT4", JdeDataType.String, 50),
        new JdeField("S5FUT5", "S5FUT5", JdeDataType.String, 50),
        new JdeField("S5X1", "S5X1", JdeDataType.String, 2),
        new JdeField("S5X2", "S5X2", JdeDataType.String, 2),
        new JdeField("S5D1FU", "S5D1FU", JdeDataType.Numeric),
        new JdeField("S5D2FU", "S5D2FU", JdeDataType.Numeric),
        new JdeField("S5TORG", "S5TORG", JdeDataType.String, 20),
        new JdeField("S5USER", "S5USER", JdeDataType.String, 20),
        new JdeField("S5PID", "S5PID", JdeDataType.String, 20),
        new JdeField("S5JOBN", "S5JOBN", JdeDataType.String, 20),
        new JdeField("S5UPMJ", "S5UPMJ", JdeDataType.Numeric),
        new JdeField("S5UPMT", "S5UPMT", JdeDataType.Numeric),
        new JdeField("S5GAN8", "S5GAN8", JdeDataType.Numeric),
        new JdeField("S5GANS8", "S5GANS8", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F470462_0", "Primary Key on S5EKCO, S5EDOC, S5EDCT", new[] { "S5EKCO", "S5EDOC", "S5EDCT" }, isUnique: true, isPrimaryKey: true)
    };
}
