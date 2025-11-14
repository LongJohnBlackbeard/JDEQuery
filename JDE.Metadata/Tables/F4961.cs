using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4961 - .
/// </summary>
public class F4961 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// LLVMCU.
        /// </summary>
        public const string LLVMCU = "LLVMCU";

        /// <summary>
        /// LLLDNM.
        /// </summary>
        public const string LLLDNM = "LLLDNM";

        /// <summary>
        /// LLTRPL.
        /// </summary>
        public const string LLTRPL = "LLTRPL";

        /// <summary>
        /// LLORGN.
        /// </summary>
        public const string LLORGN = "LLORGN";

        /// <summary>
        /// LLNMCU.
        /// </summary>
        public const string LLNMCU = "LLNMCU";

        /// <summary>
        /// LLSTSQ.
        /// </summary>
        public const string LLSTSQ = "LLSTSQ";

        /// <summary>
        /// LLSCWT.
        /// </summary>
        public const string LLSCWT = "LLSCWT";

        /// <summary>
        /// LLWTUM.
        /// </summary>
        public const string LLWTUM = "LLWTUM";

        /// <summary>
        /// LLSCVL.
        /// </summary>
        public const string LLSCVL = "LLSCVL";

        /// <summary>
        /// LLVLUM.
        /// </summary>
        public const string LLVLUM = "LLVLUM";

        /// <summary>
        /// LLSCCU.
        /// </summary>
        public const string LLSCCU = "LLSCCU";

        /// <summary>
        /// LLCVUM.
        /// </summary>
        public const string LLCVUM = "LLCVUM";

        /// <summary>
        /// LLLDDT.
        /// </summary>
        public const string LLLDDT = "LLLDDT";

        /// <summary>
        /// LLLDTM.
        /// </summary>
        public const string LLLDTM = "LLLDTM";

        /// <summary>
        /// LLLOAD.
        /// </summary>
        public const string LLLOAD = "LLLOAD";

        /// <summary>
        /// LLTMLS.
        /// </summary>
        public const string LLTMLS = "LLTMLS";

        /// <summary>
        /// LLPPDJ.
        /// </summary>
        public const string LLPPDJ = "LLPPDJ";

        /// <summary>
        /// LLPMDT.
        /// </summary>
        public const string LLPMDT = "LLPMDT";

        /// <summary>
        /// LLADDJ.
        /// </summary>
        public const string LLADDJ = "LLADDJ";

        /// <summary>
        /// LLADTM.
        /// </summary>
        public const string LLADTM = "LLADTM";

        /// <summary>
        /// LLLRFG.
        /// </summary>
        public const string LLLRFG = "LLLRFG";

        /// <summary>
        /// LLPCSD.
        /// </summary>
        public const string LLPCSD = "LLPCSD";

        /// <summary>
        /// LLDWNC.
        /// </summary>
        public const string LLDWNC = "LLDWNC";

        /// <summary>
        /// LLURCD.
        /// </summary>
        public const string LLURCD = "LLURCD";

        /// <summary>
        /// LLURDT.
        /// </summary>
        public const string LLURDT = "LLURDT";

        /// <summary>
        /// LLURAT.
        /// </summary>
        public const string LLURAT = "LLURAT";

        /// <summary>
        /// LLURAB.
        /// </summary>
        public const string LLURAB = "LLURAB";

        /// <summary>
        /// LLURRF.
        /// </summary>
        public const string LLURRF = "LLURRF";

        /// <summary>
        /// LLUSER.
        /// </summary>
        public const string LLUSER = "LLUSER";

        /// <summary>
        /// LLPID.
        /// </summary>
        public const string LLPID = "LLPID";

        /// <summary>
        /// LLJOBN.
        /// </summary>
        public const string LLJOBN = "LLJOBN";

        /// <summary>
        /// LLUPMJ.
        /// </summary>
        public const string LLUPMJ = "LLUPMJ";

        /// <summary>
        /// LLTDAY.
        /// </summary>
        public const string LLTDAY = "LLTDAY";
    }

    /// <inheritdoc />
    public override string TableName => "F4961";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("LLVMCU", "LLVMCU", JdeDataType.String, 24, true, true),
        new JdeField("LLLDNM", "LLLDNM", JdeDataType.Numeric, null, true, true),
        new JdeField("LLTRPL", "LLTRPL", JdeDataType.Numeric, null, true, true),
        new JdeField("LLORGN", "LLORGN", JdeDataType.Numeric),
        new JdeField("LLNMCU", "LLNMCU", JdeDataType.String, 24),
        new JdeField("LLSTSQ", "LLSTSQ", JdeDataType.Numeric),
        new JdeField("LLSCWT", "LLSCWT", JdeDataType.Numeric),
        new JdeField("LLWTUM", "LLWTUM", JdeDataType.String, 4),
        new JdeField("LLSCVL", "LLSCVL", JdeDataType.Numeric),
        new JdeField("LLVLUM", "LLVLUM", JdeDataType.String, 4),
        new JdeField("LLSCCU", "LLSCCU", JdeDataType.Numeric),
        new JdeField("LLCVUM", "LLCVUM", JdeDataType.String, 4),
        new JdeField("LLLDDT", "LLLDDT", JdeDataType.Numeric),
        new JdeField("LLLDTM", "LLLDTM", JdeDataType.Numeric),
        new JdeField("LLLOAD", "LLLOAD", JdeDataType.Numeric),
        new JdeField("LLTMLS", "LLTMLS", JdeDataType.Numeric),
        new JdeField("LLPPDJ", "LLPPDJ", JdeDataType.Numeric),
        new JdeField("LLPMDT", "LLPMDT", JdeDataType.Numeric),
        new JdeField("LLADDJ", "LLADDJ", JdeDataType.Numeric),
        new JdeField("LLADTM", "LLADTM", JdeDataType.Numeric),
        new JdeField("LLLRFG", "LLLRFG", JdeDataType.String, 2),
        new JdeField("LLPCSD", "LLPCSD", JdeDataType.String, 20),
        new JdeField("LLDWNC", "LLDWNC", JdeDataType.Numeric),
        new JdeField("LLURCD", "LLURCD", JdeDataType.String, 4),
        new JdeField("LLURDT", "LLURDT", JdeDataType.Numeric),
        new JdeField("LLURAT", "LLURAT", JdeDataType.Numeric),
        new JdeField("LLURAB", "LLURAB", JdeDataType.Numeric),
        new JdeField("LLURRF", "LLURRF", JdeDataType.String, 30),
        new JdeField("LLUSER", "LLUSER", JdeDataType.String, 20),
        new JdeField("LLPID", "LLPID", JdeDataType.String, 20),
        new JdeField("LLJOBN", "LLJOBN", JdeDataType.String, 20),
        new JdeField("LLUPMJ", "LLUPMJ", JdeDataType.Numeric),
        new JdeField("LLTDAY", "LLTDAY", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4961_0", "Primary Key on LLVMCU, LLLDNM, LLTRPL", new[] { "LLVMCU", "LLLDNM", "LLTRPL" }, isUnique: true, isPrimaryKey: true)
    };
}
