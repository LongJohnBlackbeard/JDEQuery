using JDE.Abstractions.Metadata;

namespace JDE.Metadata.Tables;

/// <summary>
/// F4080 - .
/// </summary>
public class F4080 : JdeTable
{
    /// <summary>
    /// Column name constants for type-safe queries.
    /// </summary>
    public static class Columns
    {
        /// <summary>
        /// ROROSID.
        /// </summary>
        public const string ROROSID = "ROROSID";

        /// <summary>
        /// ROROID.
        /// </summary>
        public const string ROROID = "ROROID";

        /// <summary>
        /// ROSY.
        /// </summary>
        public const string ROSY = "ROSY";

        /// <summary>
        /// ROOIND.
        /// </summary>
        public const string ROOIND = "ROOIND";

        /// <summary>
        /// RODOCO.
        /// </summary>
        public const string RODOCO = "RODOCO";

        /// <summary>
        /// RODCTO.
        /// </summary>
        public const string RODCTO = "RODCTO";

        /// <summary>
        /// ROKCOO.
        /// </summary>
        public const string ROKCOO = "ROKCOO";

        /// <summary>
        /// ROLNID.
        /// </summary>
        public const string ROLNID = "ROLNID";

        /// <summary>
        /// ROSFXO.
        /// </summary>
        public const string ROSFXO = "ROSFXO";

        /// <summary>
        /// ROPRJM.
        /// </summary>
        public const string ROPRJM = "ROPRJM";

        /// <summary>
        /// ROMCU.
        /// </summary>
        public const string ROMCU = "ROMCU";

        /// <summary>
        /// ROGLCM.
        /// </summary>
        public const string ROGLCM = "ROGLCM";

        /// <summary>
        /// RODOC.
        /// </summary>
        public const string RODOC = "RODOC";

        /// <summary>
        /// RODCT.
        /// </summary>
        public const string RODCT = "RODCT";

        /// <summary>
        /// ROSUB.
        /// </summary>
        public const string ROSUB = "ROSUB";

        /// <summary>
        /// ROITM.
        /// </summary>
        public const string ROITM = "ROITM";

        /// <summary>
        /// RODSC1.
        /// </summary>
        public const string RODSC1 = "RODSC1";

        /// <summary>
        /// ROUKID.
        /// </summary>
        public const string ROUKID = "ROUKID";

        /// <summary>
        /// ROWODTF.
        /// </summary>
        public const string ROWODTF = "ROWODTF";

        /// <summary>
        /// ROCRUC1.
        /// </summary>
        public const string ROCRUC1 = "ROCRUC1";

        /// <summary>
        /// ROCRUC2.
        /// </summary>
        public const string ROCRUC2 = "ROCRUC2";

        /// <summary>
        /// ROCRUC3.
        /// </summary>
        public const string ROCRUC3 = "ROCRUC3";

        /// <summary>
        /// ROCRUC4.
        /// </summary>
        public const string ROCRUC4 = "ROCRUC4";

        /// <summary>
        /// ROCRUC5.
        /// </summary>
        public const string ROCRUC5 = "ROCRUC5";

        /// <summary>
        /// ROCRUS1.
        /// </summary>
        public const string ROCRUS1 = "ROCRUS1";

        /// <summary>
        /// ROCRUS2.
        /// </summary>
        public const string ROCRUS2 = "ROCRUS2";

        /// <summary>
        /// ROCRUS3.
        /// </summary>
        public const string ROCRUS3 = "ROCRUS3";

        /// <summary>
        /// ROCRUS4.
        /// </summary>
        public const string ROCRUS4 = "ROCRUS4";

        /// <summary>
        /// ROCRUS5.
        /// </summary>
        public const string ROCRUS5 = "ROCRUS5";

        /// <summary>
        /// ROCRUN1.
        /// </summary>
        public const string ROCRUN1 = "ROCRUN1";

        /// <summary>
        /// ROCRUN2.
        /// </summary>
        public const string ROCRUN2 = "ROCRUN2";

        /// <summary>
        /// ROCRUN3.
        /// </summary>
        public const string ROCRUN3 = "ROCRUN3";

        /// <summary>
        /// ROCRUN4D2.
        /// </summary>
        public const string ROCRUN4D2 = "ROCRUN4D2";

        /// <summary>
        /// ROCRUN5D2.
        /// </summary>
        public const string ROCRUN5D2 = "ROCRUN5D2";

        /// <summary>
        /// ROCRUD.
        /// </summary>
        public const string ROCRUD = "ROCRUD";

        /// <summary>
        /// ROCRUD2.
        /// </summary>
        public const string ROCRUD2 = "ROCRUD2";

        /// <summary>
        /// ROCRUD3.
        /// </summary>
        public const string ROCRUD3 = "ROCRUD3";

        /// <summary>
        /// ROCRUD4.
        /// </summary>
        public const string ROCRUD4 = "ROCRUD4";

        /// <summary>
        /// ROCRUD5.
        /// </summary>
        public const string ROCRUD5 = "ROCRUD5";

        /// <summary>
        /// ROPID.
        /// </summary>
        public const string ROPID = "ROPID";

        /// <summary>
        /// ROJOBN.
        /// </summary>
        public const string ROJOBN = "ROJOBN";

        /// <summary>
        /// ROUPMJ.
        /// </summary>
        public const string ROUPMJ = "ROUPMJ";

        /// <summary>
        /// ROUPMT.
        /// </summary>
        public const string ROUPMT = "ROUPMT";

        /// <summary>
        /// ROUSER.
        /// </summary>
        public const string ROUSER = "ROUSER";
    }

    /// <inheritdoc />
    public override string TableName => "F4080";

    /// <inheritdoc />
    public override string Description => "";

    /// <inheritdoc />
    public override IReadOnlyList<IJdeField> Fields { get; } = new List<IJdeField>
    {
        new JdeField("ROROSID", "ROROSID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROROID", "ROROID", JdeDataType.Numeric, null, true, true),
        new JdeField("ROSY", "ROSY", JdeDataType.String, 8, true, true),
        new JdeField("ROOIND", "ROOIND", JdeDataType.Numeric, null, true, true),
        new JdeField("RODOCO", "RODOCO", JdeDataType.Numeric),
        new JdeField("RODCTO", "RODCTO", JdeDataType.String, 4),
        new JdeField("ROKCOO", "ROKCOO", JdeDataType.String, 10),
        new JdeField("ROLNID", "ROLNID", JdeDataType.Numeric),
        new JdeField("ROSFXO", "ROSFXO", JdeDataType.String, 6),
        new JdeField("ROPRJM", "ROPRJM", JdeDataType.Numeric),
        new JdeField("ROMCU", "ROMCU", JdeDataType.String, 24),
        new JdeField("ROGLCM", "ROGLCM", JdeDataType.String, 8),
        new JdeField("RODOC", "RODOC", JdeDataType.Numeric),
        new JdeField("RODCT", "RODCT", JdeDataType.String, 4),
        new JdeField("ROSUB", "ROSUB", JdeDataType.String, 16),
        new JdeField("ROITM", "ROITM", JdeDataType.Numeric),
        new JdeField("RODSC1", "RODSC1", JdeDataType.String, 60),
        new JdeField("ROUKID", "ROUKID", JdeDataType.Numeric),
        new JdeField("ROWODTF", "ROWODTF", JdeDataType.String, 2),
        new JdeField("ROCRUC1", "ROCRUC1", JdeDataType.String, 2),
        new JdeField("ROCRUC2", "ROCRUC2", JdeDataType.String, 2),
        new JdeField("ROCRUC3", "ROCRUC3", JdeDataType.String, 2),
        new JdeField("ROCRUC4", "ROCRUC4", JdeDataType.String, 2),
        new JdeField("ROCRUC5", "ROCRUC5", JdeDataType.String, 2),
        new JdeField("ROCRUS1", "ROCRUS1", JdeDataType.String, 20),
        new JdeField("ROCRUS2", "ROCRUS2", JdeDataType.String, 20),
        new JdeField("ROCRUS3", "ROCRUS3", JdeDataType.String, 20),
        new JdeField("ROCRUS4", "ROCRUS4", JdeDataType.String, 20),
        new JdeField("ROCRUS5", "ROCRUS5", JdeDataType.String, 20),
        new JdeField("ROCRUN1", "ROCRUN1", JdeDataType.Numeric),
        new JdeField("ROCRUN2", "ROCRUN2", JdeDataType.Numeric),
        new JdeField("ROCRUN3", "ROCRUN3", JdeDataType.Numeric),
        new JdeField("ROCRUN4D2", "ROCRUN4D2", JdeDataType.Numeric),
        new JdeField("ROCRUN5D2", "ROCRUN5D2", JdeDataType.Numeric),
        new JdeField("ROCRUD", "ROCRUD", JdeDataType.Numeric),
        new JdeField("ROCRUD2", "ROCRUD2", JdeDataType.Numeric),
        new JdeField("ROCRUD3", "ROCRUD3", JdeDataType.Numeric),
        new JdeField("ROCRUD4", "ROCRUD4", JdeDataType.Numeric),
        new JdeField("ROCRUD5", "ROCRUD5", JdeDataType.Numeric),
        new JdeField("ROPID", "ROPID", JdeDataType.String, 20),
        new JdeField("ROJOBN", "ROJOBN", JdeDataType.String, 20),
        new JdeField("ROUPMJ", "ROUPMJ", JdeDataType.Numeric),
        new JdeField("ROUPMT", "ROUPMT", JdeDataType.Numeric),
        new JdeField("ROUSER", "ROUSER", JdeDataType.String, 20)
    };

    /// <inheritdoc />
    public override IReadOnlyList<IJdeIndex> Indexes { get; } = new List<IJdeIndex>
    {
        new JdeIndex("F4080_0", "Primary Key on ROROSID, ROROID, ROSY, ROOIND", new[] { "ROROSID", "ROROID", "ROSY", "ROOIND" }, isUnique: true, isPrimaryKey: true),
        new JdeIndex("F4080_2", "Index on ROSY, RODOCO, RODCTO, ROKCOO, ROLNID, ROSFXO", new[] { "ROSY", "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "ROSFXO" }),
        new JdeIndex("F4080_4", "Index on ROPRJM, RODOCO, RODCTO, ROKCOO, ROLNID, ROSFXO", new[] { "ROPRJM", "RODOCO", "RODCTO", "ROKCOO", "ROLNID", "ROSFXO" }),
        new JdeIndex("F4080_5", "Index on ROROSID, ROSY", new[] { "ROROSID", "ROSY" }),
        new JdeIndex("F4080_6", "Index on ROROSID, SYS_NC00045$", new[] { "ROROSID", "SYS_NC00045$" }),
        new JdeIndex("F4080_7", "Index on ROROSID, SYS_NC00046$", new[] { "ROROSID", "SYS_NC00046$" }),
        new JdeIndex("F4080_8", "Index on ROITM", new[] { "ROITM" }),
        new JdeIndex("F4080_9", "Index on ROPRJM, RODOC, RODCT", new[] { "ROPRJM", "RODOC", "RODCT" })
    };
}
