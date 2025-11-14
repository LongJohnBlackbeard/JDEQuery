using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F1114 - .
/// </summary>
public class F1114 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// C2DOT2.
        /// </summary>
        public const string C2DOT2 = "C2DOT2";

        /// <summary>
        /// C2CO.
        /// </summary>
        public const string C2CO = "C2CO";

        /// <summary>
        /// C2FLT1.
        /// </summary>
        public const string C2FLT1 = "C2FLT1";

        /// <summary>
        /// C2FLT2.
        /// </summary>
        public const string C2FLT2 = "C2FLT2";

        /// <summary>
        /// C2FLT3.
        /// </summary>
        public const string C2FLT3 = "C2FLT3";

        /// <summary>
        /// C2TLT.
        /// </summary>
        public const string C2TLT = "C2TLT";

        /// <summary>
        /// C2CRDC.
        /// </summary>
        public const string C2CRDC = "C2CRDC";

        /// <summary>
        /// C2MCUF.
        /// </summary>
        public const string C2MCUF = "C2MCUF";

        /// <summary>
        /// C2MCUT.
        /// </summary>
        public const string C2MCUT = "C2MCUT";

        /// <summary>
        /// C2FROM.
        /// </summary>
        public const string C2FROM = "C2FROM";

        /// <summary>
        /// C2THRU.
        /// </summary>
        public const string C2THRU = "C2THRU";

        /// <summary>
        /// C2FLT.
        /// </summary>
        public const string C2FLT = "C2FLT";

        /// <summary>
        /// C2CMBP.
        /// </summary>
        public const string C2CMBP = "C2CMBP";

        /// <summary>
        /// C2RTTY.
        /// </summary>
        public const string C2RTTY = "C2RTTY";

        /// <summary>
        /// C2CRR.
        /// </summary>
        public const string C2CRR = "C2CRR";

        /// <summary>
        /// C2EXA.
        /// </summary>
        public const string C2EXA = "C2EXA";

        /// <summary>
        /// C2AID.
        /// </summary>
        public const string C2AID = "C2AID";

        /// <summary>
        /// C2AM.
        /// </summary>
        public const string C2AM = "C2AM";

        /// <summary>
        /// C2AID2.
        /// </summary>
        public const string C2AID2 = "C2AID2";

        /// <summary>
        /// C2AM2.
        /// </summary>
        public const string C2AM2 = "C2AM2";

        /// <summary>
        /// C2OBJF.
        /// </summary>
        public const string C2OBJF = "C2OBJF";

        /// <summary>
        /// C2FSUB.
        /// </summary>
        public const string C2FSUB = "C2FSUB";

        /// <summary>
        /// C2OBJT.
        /// </summary>
        public const string C2OBJT = "C2OBJT";

        /// <summary>
        /// C2SUBT.
        /// </summary>
        public const string C2SUBT = "C2SUBT";

        /// <summary>
        /// C2MOR.
        /// </summary>
        public const string C2MOR = "C2MOR";

        /// <summary>
        /// C2OBJ.
        /// </summary>
        public const string C2OBJ = "C2OBJ";

        /// <summary>
        /// C2SUB.
        /// </summary>
        public const string C2SUB = "C2SUB";

        /// <summary>
        /// C2MCU2.
        /// </summary>
        public const string C2MCU2 = "C2MCU2";

        /// <summary>
        /// C2OBJ7.
        /// </summary>
        public const string C2OBJ7 = "C2OBJ7";

        /// <summary>
        /// C2SUB2.
        /// </summary>
        public const string C2SUB2 = "C2SUB2";

        /// <summary>
        /// C2MCU.
        /// </summary>
        public const string C2MCU = "C2MCU";

        /// <summary>
        /// C2USER.
        /// </summary>
        public const string C2USER = "C2USER";

        /// <summary>
        /// C2PID.
        /// </summary>
        public const string C2PID = "C2PID";

        /// <summary>
        /// C2JOBN.
        /// </summary>
        public const string C2JOBN = "C2JOBN";

        /// <summary>
        /// C2UPMJ.
        /// </summary>
        public const string C2UPMJ = "C2UPMJ";

        /// <summary>
        /// C2UPMT.
        /// </summary>
        public const string C2UPMT = "C2UPMT";
    }

    /// <inheritdoc />
    public override string TableName => "F1114";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("C2DOT2", "C2DOT2", JdeDataType.String, 2, true, true),
        new JdeField("C2CO", "C2CO", JdeDataType.String, 10, true, true),
        new JdeField("C2FLT1", "C2FLT1", JdeDataType.String, 4, true, true),
        new JdeField("C2FLT2", "C2FLT2", JdeDataType.String, 4),
        new JdeField("C2FLT3", "C2FLT3", JdeDataType.String, 4),
        new JdeField("C2TLT", "C2TLT", JdeDataType.String, 4, true, true),
        new JdeField("C2CRDC", "C2CRDC", JdeDataType.String, 6, true, true),
        new JdeField("C2MCUF", "C2MCUF", JdeDataType.String, 24, true, true),
        new JdeField("C2MCUT", "C2MCUT", JdeDataType.String, 24),
        new JdeField("C2FROM", "C2FROM", JdeDataType.String, 30),
        new JdeField("C2THRU", "C2THRU", JdeDataType.String, 30),
        new JdeField("C2FLT", "C2FLT", JdeDataType.String, 4),
        new JdeField("C2CMBP", "C2CMBP", JdeDataType.String, 2),
        new JdeField("C2RTTY", "C2RTTY", JdeDataType.String, 4),
        new JdeField("C2CRR", "C2CRR", JdeDataType.Numeric),
        new JdeField("C2EXA", "C2EXA", JdeDataType.String, 60),
        new JdeField("C2AID", "C2AID", JdeDataType.String, 16),
        new JdeField("C2AM", "C2AM", JdeDataType.String, 2),
        new JdeField("C2AID2", "C2AID2", JdeDataType.String, 16),
        new JdeField("C2AM2", "C2AM2", JdeDataType.String, 2),
        new JdeField("C2OBJF", "C2OBJF", JdeDataType.String, 12, true, true),
        new JdeField("C2FSUB", "C2FSUB", JdeDataType.String, 16, true, true),
        new JdeField("C2OBJT", "C2OBJT", JdeDataType.String, 12),
        new JdeField("C2SUBT", "C2SUBT", JdeDataType.String, 16),
        new JdeField("C2MOR", "C2MOR", JdeDataType.String, 2),
        new JdeField("C2OBJ", "C2OBJ", JdeDataType.String, 12),
        new JdeField("C2SUB", "C2SUB", JdeDataType.String, 16),
        new JdeField("C2MCU2", "C2MCU2", JdeDataType.String, 24),
        new JdeField("C2OBJ7", "C2OBJ7", JdeDataType.String, 12),
        new JdeField("C2SUB2", "C2SUB2", JdeDataType.String, 16),
        new JdeField("C2MCU", "C2MCU", JdeDataType.String, 24),
        new JdeField("C2USER", "C2USER", JdeDataType.String, 20),
        new JdeField("C2PID", "C2PID", JdeDataType.String, 20),
        new JdeField("C2JOBN", "C2JOBN", JdeDataType.String, 20),
        new JdeField("C2UPMJ", "C2UPMJ", JdeDataType.Numeric),
        new JdeField("C2UPMT", "C2UPMT", JdeDataType.Numeric)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F1114_0", "Primary Key on C2DOT2, C2CO, C2CRDC, C2FLT1, C2TLT, C2MCUF, C2OBJF, C2FSUB", new[] { "C2DOT2", "C2CO", "C2CRDC", "C2FLT1", "C2TLT", "C2MCUF", "C2OBJF", "C2FSUB" }, isUnique: true, isPrimaryKey: true)
    };
}
