using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F5144 - .
/// </summary>
public class F5144 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// G7VERS.
        /// </summary>
        public const string G7VERS = "G7VERS";

        /// <summary>
        /// G7MCU.
        /// </summary>
        public const string G7MCU = "G7MCU";

        /// <summary>
        /// G7SBL.
        /// </summary>
        public const string G7SBL = "G7SBL";

        /// <summary>
        /// G7SBLT.
        /// </summary>
        public const string G7SBLT = "G7SBLT";

        /// <summary>
        /// G7DEF.
        /// </summary>
        public const string G7DEF = "G7DEF";

        /// <summary>
        /// G7RECM.
        /// </summary>
        public const string G7RECM = "G7RECM";

        /// <summary>
        /// G7TYRE.
        /// </summary>
        public const string G7TYRE = "G7TYRE";

        /// <summary>
        /// G7NNBR.
        /// </summary>
        public const string G7NNBR = "G7NNBR";

        /// <summary>
        /// G7PTTH.
        /// </summary>
        public const string G7PTTH = "G7PTTH";

        /// <summary>
        /// G7PTPC.
        /// </summary>
        public const string G7PTPC = "G7PTPC";

        /// <summary>
        /// G7COB.
        /// </summary>
        public const string G7COB = "G7COB";

        /// <summary>
        /// G7ROB.
        /// </summary>
        public const string G7ROB = "G7ROB";

        /// <summary>
        /// G7CCH.
        /// </summary>
        public const string G7CCH = "G7CCH";

        /// <summary>
        /// G7RCH.
        /// </summary>
        public const string G7RCH = "G7RCH";

        /// <summary>
        /// G7CATD.
        /// </summary>
        public const string G7CATD = "G7CATD";

        /// <summary>
        /// G7RATD.
        /// </summary>
        public const string G7RATD = "G7RATD";

        /// <summary>
        /// G7CPF.
        /// </summary>
        public const string G7CPF = "G7CPF";

        /// <summary>
        /// G7CPFA.
        /// </summary>
        public const string G7CPFA = "G7CPFA";

        /// <summary>
        /// G7RPF.
        /// </summary>
        public const string G7RPF = "G7RPF";

        /// <summary>
        /// G7RPFA.
        /// </summary>
        public const string G7RPFA = "G7RPFA";

        /// <summary>
        /// G7STML.
        /// </summary>
        public const string G7STML = "G7STML";

        /// <summary>
        /// G7CJTD.
        /// </summary>
        public const string G7CJTD = "G7CJTD";

        /// <summary>
        /// G7RJTD.
        /// </summary>
        public const string G7RJTD = "G7RJTD";

        /// <summary>
        /// G7CEPY.
        /// </summary>
        public const string G7CEPY = "G7CEPY";

        /// <summary>
        /// G7REPY.
        /// </summary>
        public const string G7REPY = "G7REPY";

        /// <summary>
        /// G7CEPQ.
        /// </summary>
        public const string G7CEPQ = "G7CEPQ";

        /// <summary>
        /// G7REPQ.
        /// </summary>
        public const string G7REPQ = "G7REPQ";

        /// <summary>
        /// G7CEPM.
        /// </summary>
        public const string G7CEPM = "G7CEPM";

        /// <summary>
        /// G7REPM.
        /// </summary>
        public const string G7REPM = "G7REPM";

        /// <summary>
        /// G7ZFU1.
        /// </summary>
        public const string G7ZFU1 = "G7ZFU1";

        /// <summary>
        /// G7ZFU2.
        /// </summary>
        public const string G7ZFU2 = "G7ZFU2";

        /// <summary>
        /// G7ZFU3.
        /// </summary>
        public const string G7ZFU3 = "G7ZFU3";

        /// <summary>
        /// G7ULCK.
        /// </summary>
        public const string G7ULCK = "G7ULCK";

        /// <summary>
        /// G7DGEN.
        /// </summary>
        public const string G7DGEN = "G7DGEN";

        /// <summary>
        /// G7USER.
        /// </summary>
        public const string G7USER = "G7USER";

        /// <summary>
        /// G7PID.
        /// </summary>
        public const string G7PID = "G7PID";

        /// <summary>
        /// G7UPMJ.
        /// </summary>
        public const string G7UPMJ = "G7UPMJ";

        /// <summary>
        /// G7JOBN.
        /// </summary>
        public const string G7JOBN = "G7JOBN";

        /// <summary>
        /// G7UPMT.
        /// </summary>
        public const string G7UPMT = "G7UPMT";

        /// <summary>
        /// G7VER.
        /// </summary>
        public const string G7VER = "G7VER";
    }

    /// <inheritdoc />
    public override string TableName => "F5144";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("G7VERS", "G7VERS", JdeDataType.String, 20, true, true),
        new JdeField("G7MCU", "G7MCU", JdeDataType.String, 24, true, true),
        new JdeField("G7SBL", "G7SBL", JdeDataType.String, 16, true, true),
        new JdeField("G7SBLT", "G7SBLT", JdeDataType.String, 2, true, true),
        new JdeField("G7DEF", "G7DEF", JdeDataType.Numeric, null, true, true),
        new JdeField("G7RECM", "G7RECM", JdeDataType.String, 2),
        new JdeField("G7TYRE", "G7TYRE", JdeDataType.String, 2, true, true),
        new JdeField("G7NNBR", "G7NNBR", JdeDataType.Numeric),
        new JdeField("G7PTTH", "G7PTTH", JdeDataType.String, 2),
        new JdeField("G7PTPC", "G7PTPC", JdeDataType.Numeric),
        new JdeField("G7COB", "G7COB", JdeDataType.Numeric),
        new JdeField("G7ROB", "G7ROB", JdeDataType.Numeric),
        new JdeField("G7CCH", "G7CCH", JdeDataType.Numeric),
        new JdeField("G7RCH", "G7RCH", JdeDataType.Numeric),
        new JdeField("G7CATD", "G7CATD", JdeDataType.Numeric),
        new JdeField("G7RATD", "G7RATD", JdeDataType.Numeric),
        new JdeField("G7CPF", "G7CPF", JdeDataType.Numeric),
        new JdeField("G7CPFA", "G7CPFA", JdeDataType.Numeric),
        new JdeField("G7RPF", "G7RPF", JdeDataType.Numeric),
        new JdeField("G7RPFA", "G7RPFA", JdeDataType.Numeric),
        new JdeField("G7STML", "G7STML", JdeDataType.Numeric),
        new JdeField("G7CJTD", "G7CJTD", JdeDataType.Numeric),
        new JdeField("G7RJTD", "G7RJTD", JdeDataType.Numeric),
        new JdeField("G7CEPY", "G7CEPY", JdeDataType.Numeric),
        new JdeField("G7REPY", "G7REPY", JdeDataType.Numeric),
        new JdeField("G7CEPQ", "G7CEPQ", JdeDataType.Numeric),
        new JdeField("G7REPQ", "G7REPQ", JdeDataType.Numeric),
        new JdeField("G7CEPM", "G7CEPM", JdeDataType.Numeric),
        new JdeField("G7REPM", "G7REPM", JdeDataType.Numeric),
        new JdeField("G7ZFU1", "G7ZFU1", JdeDataType.String, 2),
        new JdeField("G7ZFU2", "G7ZFU2", JdeDataType.String, 2),
        new JdeField("G7ZFU3", "G7ZFU3", JdeDataType.String, 2),
        new JdeField("G7ULCK", "G7ULCK", JdeDataType.String, 20),
        new JdeField("G7DGEN", "G7DGEN", JdeDataType.Numeric),
        new JdeField("G7USER", "G7USER", JdeDataType.String, 20),
        new JdeField("G7PID", "G7PID", JdeDataType.String, 20),
        new JdeField("G7UPMJ", "G7UPMJ", JdeDataType.Numeric),
        new JdeField("G7JOBN", "G7JOBN", JdeDataType.String, 20),
        new JdeField("G7UPMT", "G7UPMT", JdeDataType.Numeric),
        new JdeField("G7VER", "G7VER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F5144_0", "Primary Key on G7VERS, G7MCU, G7SBL, G7SBLT, G7DEF, G7TYRE", new[] { "G7VERS", "G7MCU", "G7SBL", "G7SBLT", "G7DEF", "G7TYRE" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F5144_3", "Index on G7MCU, SYS_NC00041$", new[] { "G7MCU", "SYS_NC00041$" }),
        new JdeIndex("F5144_4", "Index on G7MCU, G7SBL, G7SBLT, G7DEF, G7TYRE", new[] { "G7MCU", "G7SBL", "G7SBLT", "G7DEF", "G7TYRE" }),
        new JdeIndex("F5144_5", "Index on G7MCU, G7DEF, G7TYRE", new[] { "G7MCU", "G7DEF", "G7TYRE" }),
        new JdeIndex("F5144_6", "Index on G7DEF, G7NNBR", new[] { "G7DEF", "G7NNBR" })
    };
}
