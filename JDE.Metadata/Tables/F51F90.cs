using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F51F90 - .
/// </summary>
public class F51F90 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// QN51FFN.
        /// </summary>
        public const string QN51FFN = "QN51FFN";

        /// <summary>
        /// QN51FFD.
        /// </summary>
        public const string QN51FFD = "QN51FFD";

        /// <summary>
        /// QN51FC1.
        /// </summary>
        public const string QN51FC1 = "QN51FC1";

        /// <summary>
        /// QN51FCT1.
        /// </summary>
        public const string QN51FCT1 = "QN51FCT1";

        /// <summary>
        /// QN51FC2.
        /// </summary>
        public const string QN51FC2 = "QN51FC2";

        /// <summary>
        /// QN51FCT2.
        /// </summary>
        public const string QN51FCT2 = "QN51FCT2";

        /// <summary>
        /// QN51FC3.
        /// </summary>
        public const string QN51FC3 = "QN51FC3";

        /// <summary>
        /// QN51FCT3.
        /// </summary>
        public const string QN51FCT3 = "QN51FCT3";

        /// <summary>
        /// QN51FC4.
        /// </summary>
        public const string QN51FC4 = "QN51FC4";

        /// <summary>
        /// QN51FCT4.
        /// </summary>
        public const string QN51FCT4 = "QN51FCT4";

        /// <summary>
        /// QN51FC5.
        /// </summary>
        public const string QN51FC5 = "QN51FC5";

        /// <summary>
        /// QN51FCT5.
        /// </summary>
        public const string QN51FCT5 = "QN51FCT5";

        /// <summary>
        /// QN51FC6.
        /// </summary>
        public const string QN51FC6 = "QN51FC6";

        /// <summary>
        /// QN51FCT6.
        /// </summary>
        public const string QN51FCT6 = "QN51FCT6";

        /// <summary>
        /// QN51FC7.
        /// </summary>
        public const string QN51FC7 = "QN51FC7";

        /// <summary>
        /// QN51FCT7.
        /// </summary>
        public const string QN51FCT7 = "QN51FCT7";

        /// <summary>
        /// QN51FC8.
        /// </summary>
        public const string QN51FC8 = "QN51FC8";

        /// <summary>
        /// QN51FCT8.
        /// </summary>
        public const string QN51FCT8 = "QN51FCT8";

        /// <summary>
        /// QN51FC9.
        /// </summary>
        public const string QN51FC9 = "QN51FC9";

        /// <summary>
        /// QN51FCT9.
        /// </summary>
        public const string QN51FCT9 = "QN51FCT9";

        /// <summary>
        /// QN51FC10.
        /// </summary>
        public const string QN51FC10 = "QN51FC10";

        /// <summary>
        /// QN51FCT10.
        /// </summary>
        public const string QN51FCT10 = "QN51FCT10";

        /// <summary>
        /// QN51FC11.
        /// </summary>
        public const string QN51FC11 = "QN51FC11";

        /// <summary>
        /// QN51FCT11.
        /// </summary>
        public const string QN51FCT11 = "QN51FCT11";

        /// <summary>
        /// QN51FC12.
        /// </summary>
        public const string QN51FC12 = "QN51FC12";

        /// <summary>
        /// QN51FCT12.
        /// </summary>
        public const string QN51FCT12 = "QN51FCT12";

        /// <summary>
        /// QN51FC13.
        /// </summary>
        public const string QN51FC13 = "QN51FC13";

        /// <summary>
        /// QN51FCT13.
        /// </summary>
        public const string QN51FCT13 = "QN51FCT13";

        /// <summary>
        /// QN51FC14.
        /// </summary>
        public const string QN51FC14 = "QN51FC14";

        /// <summary>
        /// QN51FCT14.
        /// </summary>
        public const string QN51FCT14 = "QN51FCT14";

        /// <summary>
        /// QN51FC15.
        /// </summary>
        public const string QN51FC15 = "QN51FC15";

        /// <summary>
        /// QN51FCT15.
        /// </summary>
        public const string QN51FCT15 = "QN51FCT15";

        /// <summary>
        /// QN51FC16.
        /// </summary>
        public const string QN51FC16 = "QN51FC16";

        /// <summary>
        /// QN51FCT16.
        /// </summary>
        public const string QN51FCT16 = "QN51FCT16";

        /// <summary>
        /// QN51FC17.
        /// </summary>
        public const string QN51FC17 = "QN51FC17";

        /// <summary>
        /// QN51FCT17.
        /// </summary>
        public const string QN51FCT17 = "QN51FCT17";

        /// <summary>
        /// QN51FC18.
        /// </summary>
        public const string QN51FC18 = "QN51FC18";

        /// <summary>
        /// QN51FCT18.
        /// </summary>
        public const string QN51FCT18 = "QN51FCT18";

        /// <summary>
        /// QN51FC19.
        /// </summary>
        public const string QN51FC19 = "QN51FC19";

        /// <summary>
        /// QN51FCT19.
        /// </summary>
        public const string QN51FCT19 = "QN51FCT19";

        /// <summary>
        /// QN51FC20.
        /// </summary>
        public const string QN51FC20 = "QN51FC20";

        /// <summary>
        /// QN51FCT20.
        /// </summary>
        public const string QN51FCT20 = "QN51FCT20";

        /// <summary>
        /// QN51FC21.
        /// </summary>
        public const string QN51FC21 = "QN51FC21";

        /// <summary>
        /// QN51FCT21.
        /// </summary>
        public const string QN51FCT21 = "QN51FCT21";

        /// <summary>
        /// QN51FC22.
        /// </summary>
        public const string QN51FC22 = "QN51FC22";

        /// <summary>
        /// QN51FCT22.
        /// </summary>
        public const string QN51FCT22 = "QN51FCT22";

        /// <summary>
        /// QN51FC23.
        /// </summary>
        public const string QN51FC23 = "QN51FC23";

        /// <summary>
        /// QN51FCT23.
        /// </summary>
        public const string QN51FCT23 = "QN51FCT23";

        /// <summary>
        /// QN51FC24.
        /// </summary>
        public const string QN51FC24 = "QN51FC24";

        /// <summary>
        /// QN51FCT24.
        /// </summary>
        public const string QN51FCT24 = "QN51FCT24";

        /// <summary>
        /// QN51FO1.
        /// </summary>
        public const string QN51FO1 = "QN51FO1";

        /// <summary>
        /// QN51FO2.
        /// </summary>
        public const string QN51FO2 = "QN51FO2";

        /// <summary>
        /// QN51FO3.
        /// </summary>
        public const string QN51FO3 = "QN51FO3";

        /// <summary>
        /// QN51FO4.
        /// </summary>
        public const string QN51FO4 = "QN51FO4";

        /// <summary>
        /// QN51FO5.
        /// </summary>
        public const string QN51FO5 = "QN51FO5";

        /// <summary>
        /// QN51FO6.
        /// </summary>
        public const string QN51FO6 = "QN51FO6";

        /// <summary>
        /// QN51FO7.
        /// </summary>
        public const string QN51FO7 = "QN51FO7";

        /// <summary>
        /// QN51FO8.
        /// </summary>
        public const string QN51FO8 = "QN51FO8";

        /// <summary>
        /// QN51FO9.
        /// </summary>
        public const string QN51FO9 = "QN51FO9";

        /// <summary>
        /// QN51FO10.
        /// </summary>
        public const string QN51FO10 = "QN51FO10";

        /// <summary>
        /// QN51FO11.
        /// </summary>
        public const string QN51FO11 = "QN51FO11";

        /// <summary>
        /// QN51FO12.
        /// </summary>
        public const string QN51FO12 = "QN51FO12";

        /// <summary>
        /// QN51FO13.
        /// </summary>
        public const string QN51FO13 = "QN51FO13";

        /// <summary>
        /// QN51FO14.
        /// </summary>
        public const string QN51FO14 = "QN51FO14";

        /// <summary>
        /// QN51FO15.
        /// </summary>
        public const string QN51FO15 = "QN51FO15";

        /// <summary>
        /// QN51FO16.
        /// </summary>
        public const string QN51FO16 = "QN51FO16";

        /// <summary>
        /// QN51FO17.
        /// </summary>
        public const string QN51FO17 = "QN51FO17";

        /// <summary>
        /// QN51FO18.
        /// </summary>
        public const string QN51FO18 = "QN51FO18";

        /// <summary>
        /// QN51FO19.
        /// </summary>
        public const string QN51FO19 = "QN51FO19";

        /// <summary>
        /// QN51FO20.
        /// </summary>
        public const string QN51FO20 = "QN51FO20";

        /// <summary>
        /// QN51FO21.
        /// </summary>
        public const string QN51FO21 = "QN51FO21";

        /// <summary>
        /// QN51FO22.
        /// </summary>
        public const string QN51FO22 = "QN51FO22";

        /// <summary>
        /// QN51FO23.
        /// </summary>
        public const string QN51FO23 = "QN51FO23";

        /// <summary>
        /// QN51FFRM.
        /// </summary>
        public const string QN51FFRM = "QN51FFRM";

        /// <summary>
        /// QNENTJ.
        /// </summary>
        public const string QNENTJ = "QNENTJ";

        /// <summary>
        /// QNTENT.
        /// </summary>
        public const string QNTENT = "QNTENT";

        /// <summary>
        /// QNUSER.
        /// </summary>
        public const string QNUSER = "QNUSER";

        /// <summary>
        /// QNUPMJ.
        /// </summary>
        public const string QNUPMJ = "QNUPMJ";

        /// <summary>
        /// QNUPMT.
        /// </summary>
        public const string QNUPMT = "QNUPMT";

        /// <summary>
        /// QNJOBN.
        /// </summary>
        public const string QNJOBN = "QNJOBN";

        /// <summary>
        /// QNPID.
        /// </summary>
        public const string QNPID = "QNPID";

        /// <summary>
        /// QNMKEY.
        /// </summary>
        public const string QNMKEY = "QNMKEY";
    }

    /// <inheritdoc />
    public override string TableName => "F51F90";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("QN51FFN", "QN51FFN", JdeDataType.String, 12, true, true),
        new JdeField("QN51FFD", "QN51FFD", JdeDataType.String, 60),
        new JdeField("QN51FC1", "QN51FC1", JdeDataType.String, 12),
        new JdeField("QN51FCT1", "QN51FCT1", JdeDataType.String, 2),
        new JdeField("QN51FC2", "QN51FC2", JdeDataType.String, 12),
        new JdeField("QN51FCT2", "QN51FCT2", JdeDataType.String, 2),
        new JdeField("QN51FC3", "QN51FC3", JdeDataType.String, 12),
        new JdeField("QN51FCT3", "QN51FCT3", JdeDataType.String, 2),
        new JdeField("QN51FC4", "QN51FC4", JdeDataType.String, 12),
        new JdeField("QN51FCT4", "QN51FCT4", JdeDataType.String, 2),
        new JdeField("QN51FC5", "QN51FC5", JdeDataType.String, 12),
        new JdeField("QN51FCT5", "QN51FCT5", JdeDataType.String, 2),
        new JdeField("QN51FC6", "QN51FC6", JdeDataType.String, 12),
        new JdeField("QN51FCT6", "QN51FCT6", JdeDataType.String, 2),
        new JdeField("QN51FC7", "QN51FC7", JdeDataType.String, 12),
        new JdeField("QN51FCT7", "QN51FCT7", JdeDataType.String, 2),
        new JdeField("QN51FC8", "QN51FC8", JdeDataType.String, 12),
        new JdeField("QN51FCT8", "QN51FCT8", JdeDataType.String, 2),
        new JdeField("QN51FC9", "QN51FC9", JdeDataType.String, 12),
        new JdeField("QN51FCT9", "QN51FCT9", JdeDataType.String, 2),
        new JdeField("QN51FC10", "QN51FC10", JdeDataType.String, 12),
        new JdeField("QN51FCT10", "QN51FCT10", JdeDataType.String, 2),
        new JdeField("QN51FC11", "QN51FC11", JdeDataType.String, 12),
        new JdeField("QN51FCT11", "QN51FCT11", JdeDataType.String, 2),
        new JdeField("QN51FC12", "QN51FC12", JdeDataType.String, 12),
        new JdeField("QN51FCT12", "QN51FCT12", JdeDataType.String, 2),
        new JdeField("QN51FC13", "QN51FC13", JdeDataType.String, 12),
        new JdeField("QN51FCT13", "QN51FCT13", JdeDataType.String, 2),
        new JdeField("QN51FC14", "QN51FC14", JdeDataType.String, 12),
        new JdeField("QN51FCT14", "QN51FCT14", JdeDataType.String, 2),
        new JdeField("QN51FC15", "QN51FC15", JdeDataType.String, 12),
        new JdeField("QN51FCT15", "QN51FCT15", JdeDataType.String, 2),
        new JdeField("QN51FC16", "QN51FC16", JdeDataType.String, 12),
        new JdeField("QN51FCT16", "QN51FCT16", JdeDataType.String, 2),
        new JdeField("QN51FC17", "QN51FC17", JdeDataType.String, 12),
        new JdeField("QN51FCT17", "QN51FCT17", JdeDataType.String, 2),
        new JdeField("QN51FC18", "QN51FC18", JdeDataType.String, 12),
        new JdeField("QN51FCT18", "QN51FCT18", JdeDataType.String, 2),
        new JdeField("QN51FC19", "QN51FC19", JdeDataType.String, 12),
        new JdeField("QN51FCT19", "QN51FCT19", JdeDataType.String, 2),
        new JdeField("QN51FC20", "QN51FC20", JdeDataType.String, 12),
        new JdeField("QN51FCT20", "QN51FCT20", JdeDataType.String, 2),
        new JdeField("QN51FC21", "QN51FC21", JdeDataType.String, 12),
        new JdeField("QN51FCT21", "QN51FCT21", JdeDataType.String, 2),
        new JdeField("QN51FC22", "QN51FC22", JdeDataType.String, 12),
        new JdeField("QN51FCT22", "QN51FCT22", JdeDataType.String, 2),
        new JdeField("QN51FC23", "QN51FC23", JdeDataType.String, 12),
        new JdeField("QN51FCT23", "QN51FCT23", JdeDataType.String, 2),
        new JdeField("QN51FC24", "QN51FC24", JdeDataType.String, 12),
        new JdeField("QN51FCT24", "QN51FCT24", JdeDataType.String, 2),
        new JdeField("QN51FO1", "QN51FO1", JdeDataType.String, 2),
        new JdeField("QN51FO2", "QN51FO2", JdeDataType.String, 2),
        new JdeField("QN51FO3", "QN51FO3", JdeDataType.String, 2),
        new JdeField("QN51FO4", "QN51FO4", JdeDataType.String, 2),
        new JdeField("QN51FO5", "QN51FO5", JdeDataType.String, 2),
        new JdeField("QN51FO6", "QN51FO6", JdeDataType.String, 2),
        new JdeField("QN51FO7", "QN51FO7", JdeDataType.String, 2),
        new JdeField("QN51FO8", "QN51FO8", JdeDataType.String, 2),
        new JdeField("QN51FO9", "QN51FO9", JdeDataType.String, 2),
        new JdeField("QN51FO10", "QN51FO10", JdeDataType.String, 2),
        new JdeField("QN51FO11", "QN51FO11", JdeDataType.String, 2),
        new JdeField("QN51FO12", "QN51FO12", JdeDataType.String, 2),
        new JdeField("QN51FO13", "QN51FO13", JdeDataType.String, 2),
        new JdeField("QN51FO14", "QN51FO14", JdeDataType.String, 2),
        new JdeField("QN51FO15", "QN51FO15", JdeDataType.String, 2),
        new JdeField("QN51FO16", "QN51FO16", JdeDataType.String, 2),
        new JdeField("QN51FO17", "QN51FO17", JdeDataType.String, 2),
        new JdeField("QN51FO18", "QN51FO18", JdeDataType.String, 2),
        new JdeField("QN51FO19", "QN51FO19", JdeDataType.String, 2),
        new JdeField("QN51FO20", "QN51FO20", JdeDataType.String, 2),
        new JdeField("QN51FO21", "QN51FO21", JdeDataType.String, 2),
        new JdeField("QN51FO22", "QN51FO22", JdeDataType.String, 2),
        new JdeField("QN51FO23", "QN51FO23", JdeDataType.String, 2),
        new JdeField("QN51FFRM", "QN51FFRM", JdeDataType.String, 160),
        new JdeField("QNENTJ", "QNENTJ", JdeDataType.Numeric),
        new JdeField("QNTENT", "QNTENT", JdeDataType.Numeric),
        new JdeField("QNUSER", "QNUSER", JdeDataType.String, 20),
        new JdeField("QNUPMJ", "QNUPMJ", JdeDataType.Numeric),
        new JdeField("QNUPMT", "QNUPMT", JdeDataType.Numeric),
        new JdeField("QNJOBN", "QNJOBN", JdeDataType.String, 20),
        new JdeField("QNPID", "QNPID", JdeDataType.String, 20),
        new JdeField("QNMKEY", "QNMKEY", JdeDataType.String, 30)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F51F90_0", "Primary Key on QN51FFN", new[] { "QN51FFN" }, isUnique: true, isPrimaryKey: true)
    };
}
